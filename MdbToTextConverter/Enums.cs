using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdbToTextConverter
{
	#region Enumerations

	internal enum ConversionMode
	{
		None,
		Directory,
		File,
	}

	[Flags]
	internal enum OutputFormat
	{
		None = 0,
		Xml = 1,
		Text = 2,
		All = Xml | Text,
	}

	internal enum OutputType
	{
		None,
		OneBigFile,
		IndividualFiles,
	}

	#endregion Enumerations
}