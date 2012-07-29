using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace MdbToTextConverter
{
	internal class MdbToTextProcessor
	{
		#region --Public Static Members--

		public static void Process(ProcessingValues processingValues)
		{
			foreach (string path in processingValues.MdbFilePaths.DefaultCollectionIfEmpty())
			{
				MdbToTextProcessor.ProcessMdb(processingValues, path);
			}
		}

		#endregion --Public Static Members--

		#region --Private Static Members--

		private static void ProcessMdb(ProcessingValues processingValues, string path)
		{
			using (OleDbConnection connection = new OleDbConnection(string.Format(ProcessingStrings.OledbConnectionStringFormat, path)))
			{
				connection.Open();

				DataSet allTables = new DataSet();
				DataTable schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, ProcessingStrings.TableSchemaIdentifier });

				foreach (DataRow row in schema.Rows)
				{
					DataTable newDataTable = new DataTable(row[ProcessingStrings.TableNameSchemaValue].ToString());

					OleDbDataAdapter adapter = new OleDbDataAdapter(string.Format(ProcessingStrings.SqlSelectTableValuesFormat, newDataTable.TableName), connection);
					adapter.Fill(newDataTable);

					/* If processing individual files, don't both filling the DataSet with table info.  Just process and
					 * move to the next.  No need to take up memory holding on to it. */
					if (processingValues.OutputType == OutputType.IndividualFiles)
					{
						MdbToTextProcessor.WriteFileForDataTable(processingValues, newDataTable);
					}
					else
					{
						/* REFACTOR:  Rather than storing the DataSet in memory and outputting all at the end, I should just append
						 * to an existing file as I loop over the rows. */
						allTables.Tables.Add(newDataTable);
					}
				}

				if (processingValues.OutputType == OutputType.OneBigFile)
				{
					MdbToTextProcessor.WriteOneBigFile(processingValues, path, allTables);
				}
			}
		}

		private static void WriteFileForDataTable(ProcessingValues processingValues, DataTable newDataTable)
		{
			if (processingValues.OutputFormat.Has(OutputFormat.Xml))
			{
				MdbToTextProcessor.WriteXmlForDataTable(processingValues, newDataTable);
			}

			if (processingValues.OutputFormat.Has(OutputFormat.Text))
			{
				MdbToTextProcessor.WriteTextForDataTable(processingValues, newDataTable);
			}
		}

		private static void WriteOneBigFile(ProcessingValues processingValues, string path, DataSet allTables)
		{
			string mdbName = Path.GetFileNameWithoutExtension(path);

			if (processingValues.OutputFormat.Has(OutputFormat.Xml))
			{
				MdbToTextProcessor.WriteXmlForDataSet(processingValues, allTables, mdbName);
			}

			if (processingValues.OutputFormat.Has(OutputFormat.Text))
			{
				MdbToTextProcessor.WriteTextForDataSet(processingValues, allTables, mdbName);
			}
		}

		private static void WriteTextForDataSet(ProcessingValues processingValues, DataSet allTables, string mdbName)
		{
			string outputTxtPath = Path.Combine(processingValues.OutputPath, string.Format(ProcessingStrings.DataSetTextFileNameFormat, mdbName));
			File.Delete(outputTxtPath);

			StringBuilder mdbContents = new StringBuilder();
			StringBuilder tableContents = new StringBuilder();
			StringBuilder rowContents = new StringBuilder();

			for (int tableIndex = 0; tableIndex < allTables.Tables.Count; tableIndex++)
			{
				DataTable table = allTables.Tables[tableIndex];

				for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
				{
					DataRow row = table.Rows[rowIndex];

					for (int itemIndex = 0; itemIndex < row.ItemArray.Length; itemIndex++)
					{
						rowContents.Append(row.ItemArray[itemIndex].ToString());
						rowContents.Append(ProcessingStrings.CommaSeparator);
					}

					tableContents.Append(rowContents.ToString());
					tableContents.Append(Environment.NewLine);
					rowContents.Length = 0;
				}

				string tableNameHeader = string.Format(ProcessingStrings.TableNameLabelFormat, table.TableName);
				string separator = string.Empty.PadLeft(table.TableName.Length + tableNameHeader.Length, '-');
				mdbContents.Append(separator);
				mdbContents.Append(Environment.NewLine);
				mdbContents.Append(tableNameHeader);
				mdbContents.Append(Environment.NewLine);
				mdbContents.Append(separator);
				mdbContents.Append(Environment.NewLine);
				mdbContents.Append(tableContents.ToString());
				mdbContents.Append(Environment.NewLine);
				mdbContents.Append(Environment.NewLine);
				tableContents.Length = 0;
			}

			File.AppendAllText(outputTxtPath, mdbContents.ToString());
		}

		private static void WriteTextForDataTable(ProcessingValues processingValues, DataTable newDataTable)
		{
			string outputTxtPath = Path.Combine(processingValues.OutputPath, string.Format(ProcessingStrings.DataTableTextFileNameFormat, newDataTable.TableName));
			File.Delete(outputTxtPath);
			StringBuilder tableContents = new StringBuilder();
			StringBuilder rowContents = new StringBuilder();

			for (int rowIndex = 0; rowIndex < newDataTable.Rows.Count; rowIndex++)
			{
				for (int itemIndex = 0; itemIndex < newDataTable.Rows[rowIndex].ItemArray.Length; itemIndex++)
				{
					rowContents.Append(newDataTable.Rows[rowIndex].ItemArray[itemIndex].ToString());
					rowContents.Append(ProcessingStrings.CommaSeparator);
				}

				tableContents.Append(rowContents.ToString());
				tableContents.Append(Environment.NewLine);
				rowContents.Length = 0;
			}

			File.AppendAllText(outputTxtPath, tableContents.ToString());
		}

		private static void WriteXmlForDataSet(ProcessingValues processingValues, DataSet allTables, string mdbName)
		{
			string outputXmlPath = Path.Combine(processingValues.OutputPath, string.Format(ProcessingStrings.DataSetXmlFileNameFormat, mdbName));
			File.Delete(outputXmlPath);
			allTables.WriteXml(outputXmlPath);
		}

		private static void WriteXmlForDataTable(ProcessingValues processingValues, DataTable newDataTable)
		{
			string outputXmlPath = Path.Combine(processingValues.OutputPath, string.Format(ProcessingStrings.DataTableXmlFileNameFormat, newDataTable.TableName));
			File.Delete(outputXmlPath);
			newDataTable.WriteXml(outputXmlPath);
		}

		#endregion --Private Static Members--

		#region --Helper Classes--

		public struct ProcessingValues
		{
			#region --Public Properties--

			public IEnumerable<string> MdbFilePaths
			{
				get;
				set;
			}

			public string MdbPath
			{
				get;
				set;
			}

			public OutputFormat OutputFormat
			{
				get;
				set;
			}

			public string OutputPath
			{
				get;
				set;
			}

			public OutputType OutputType
			{
				get;
				set;
			}

			#endregion --Public Properties--
		}

		#endregion --Helper Classes--
	}
}