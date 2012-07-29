using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdbToTextConverter
{
	public partial class MainForm : Form
	{
		#region --Ctor(s) & Setup--

		public MainForm()
		{
			InitializeComponent();

			this.SetUpForm();
		}

		private void SetUpForm()
		{
			this.btnOK.Click += new EventHandler(btnOK_Click);
			this.btnCancel.Click += new EventHandler(btnCancel_Click);
			this.btnMdbPath.Click += new System.EventHandler(this.btnMdbPath_Click);
			this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
		}

		#endregion --Ctor(s) & Setup--

		#region --Private Properties--

		private ConversionMode ConversionMode
		{
			get
			{
				return rdoDirectory.Checked ? ConversionMode.Directory : ConversionMode.File;
			}
		}

		private string MdbPath
		{
			get
			{
				return this.txtMdbPath.Text;
			}
			set
			{
				this.txtMdbPath.Text = value;
			}
		}

		private OutputFormat OutputFormat
		{
			get
			{
				OutputFormat format = OutputFormat.None;

				if (this.rdoText.Checked)
				{
					format = OutputFormat.Text;
				}
				else if (this.rdoXml.Checked)
				{
					format = OutputFormat.Xml;
				}
				else
				{
					format = OutputFormat.All;
				}

				return format;
			}
		}

		private string OutputPath
		{
			get
			{
				return this.txtOutputPath.Text;
			}
			set
			{
				this.txtOutputPath.Text = value;
			}
		}

		private OutputType OutputType
		{
			get
			{
				OutputType type = OutputType.None;

				if (this.rdoIndividual.Checked)
				{
					type = OutputType.IndividualFiles;
				}
				else
				{
					type = OutputType.OneBigFile;
				}

				return type;
			}
		}

		#endregion --Private Properties--

		#region --Event Handlers--

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.CancelButtonClickEventHandler();
		}

		private void btnMdbPath_Click(object sender, EventArgs e)
		{
			this.ChangeMdbPath();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			this.Process();
		}

		private void btnOutputPath_Click(object sender, EventArgs e)
		{
			this.ChangeOutputPath();
		}

		#endregion --Event Handlers--

		#region --Private Methods--

		private void CancelButtonClickEventHandler()
		{
			this.Close();
		}

		private void ChangeMdbPath()
		{
			if (rdoDirectory.Checked)
			{
				this.ChangeMdbPathToDirectory();
			}
			else if (rdoFile.Checked)
			{
				this.ChangeMdbPathToFile();
			}
		}

		private void ChangeMdbPathToDirectory()
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				dialog.ShowNewFolderButton = false;

				if ((this.MdbPath.Length > 0) && Directory.Exists(this.MdbPath))
				{
					dialog.SelectedPath = this.MdbPath;
				}

				DialogResult dialogResult = dialog.ShowDialog(this);

				if (dialogResult == DialogResult.OK)
				{
					this.MdbPath = dialog.SelectedPath;
				}
			}
		}

		private void ChangeMdbPathToFile()
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Multiselect = false;

				DialogResult dialogResult = dialog.ShowDialog(this);

				if (dialogResult == DialogResult.OK)
				{
					this.MdbPath = dialog.FileName;
				}
			}
		}

		private void ChangeOutputPath()
		{
			string selectedPath = this.DetermineFolderBrowserPath();

			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				dialog.ShowNewFolderButton = true;
				dialog.SelectedPath = selectedPath;

				DialogResult dialogResult = dialog.ShowDialog(this);

				if (dialogResult == DialogResult.OK)
				{
					this.OutputPath = dialog.SelectedPath;
				}
			}
		}

		private string DetermineFolderBrowserPath()
		{
			string selectedPath = null;

			/* If user provided valid output path, use that path as the selected path for the folder browser's selected path. */
			bool validOutputPathProvided = (this.OutputPath.Length > 0) && Directory.Exists(this.OutputPath);
			if (validOutputPathProvided)
			{
				selectedPath = this.OutputPath;
			}
			else
			{
				/* Fall back to mdb path as selected path if mdb path is valid. */
				bool mdbPathProvided = (this.MdbPath.Length > 0);
				if (mdbPathProvided)
				{
					/* If converting all files in directory, provided mdb path will be a directory, and we validate its existence before
					 * choosing.  If converting specific file, validate that the file path exists, and if it does use the file's directory
					 * as the selected path.  Could have shortened logic below by combining conditionals and using "else if,", but
					 * it would not have been as clear. */
					if (rdoDirectory.Checked)
					{
						if (Directory.Exists(this.MdbPath))
						{
							selectedPath = this.MdbPath;
						}
					}
					else
					{
						if (File.Exists(this.MdbPath))
						{
							selectedPath = Path.GetDirectoryName(this.MdbPath);
						}
					}
				}
			}

			return selectedPath;
		}

		private IEnumerable<string> GetFilePathsForProcessing()
		{
			List<string> filePaths = null;

			switch (this.ConversionMode)
			{
				case ConversionMode.Directory:
					DirectoryInfo directoryInfo = new DirectoryInfo(this.MdbPath);
					List<FileInfo> fileInfos = directoryInfo.GetFiles().ToList();
					filePaths = fileInfos.Where(x => x.Extension.ToLower() == ProcessingStrings.MdbExtension).Select(x => x.FullName).ToList();
					break;
				case ConversionMode.File:
					filePaths.Add(this.MdbPath);
					break;
			}

			return filePaths ?? new List<string>();
		}

		private void Process()
		{
			if (!this.ValidateInput())
			{
				return;
			}

			MdbToTextProcessor.ProcessingValues values = new MdbToTextProcessor.ProcessingValues()
			{
				MdbFilePaths = this.GetFilePathsForProcessing(),
				MdbPath = this.MdbPath,
				OutputFormat = this.OutputFormat,
				OutputPath = this.OutputPath,
				OutputType = this.OutputType,
			};

			MdbToTextProcessor.Process(values);

			MessageBox.Show(FormMessageStrings.OutputComplete, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private bool ValidateInput()
		{
			bool isValid = true;

			switch (this.ConversionMode)
			{
				case ConversionMode.Directory:
					isValid = this.ValidateMdbDirectory();
					break;
				case ConversionMode.File:
					isValid = this.ValidateMdbFile();
					break;
			}

			if (isValid && !System.IO.Directory.Exists(this.OutputPath))
			{
				MessageBox.Show(FormMessageStrings.OutputPathDNE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtOutputPath.Focus();
				isValid = false;
			}

			return isValid;
		}

		private bool ValidateMdbDirectory()
		{
			bool isValid = true;

			DirectoryInfo directoryInfo = new DirectoryInfo(this.MdbPath);

			if (!directoryInfo.Exists)
			{
				MessageBox.Show(FormMessageStrings.DirectoryDNE);
				this.txtMdbPath.Focus();
				isValid = false;
			}

			if (isValid)
			{
				List<FileInfo> fileInfos = directoryInfo.GetFiles().ToList();
				int fileCount = fileInfos.Count(x => x.Extension.ToLower() == ProcessingStrings.MdbExtension);

				if (fileCount == 0)
				{
					MessageBox.Show(FormMessageStrings.DirectoryHasNoMdbs);
					this.txtMdbPath.Focus();
					isValid = false;
				}
			}

			return isValid;
		}

		private bool ValidateMdbFile()
		{
			bool isValid = true;

			if (!File.Exists(this.MdbPath))
			{
				MessageBox.Show(FormMessageStrings.FileDNE);
				this.txtMdbPath.Focus();
				isValid = false;
			}

			if (isValid && (Path.GetExtension(this.MdbPath).ToLower() != ProcessingStrings.MdbExtension))
			{
				MessageBox.Show(FormMessageStrings.InvalidMdbFile, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtMdbPath.Focus();
				isValid = false;
			}

			return isValid;
		}

		#endregion --Private Methods--
	}
}