namespace MdbToTextConverter
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMdbPath = new System.Windows.Forms.TextBox();
			this.btnMdbPath = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOutputPath = new System.Windows.Forms.TextBox();
			this.btnOutputPath = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.rdoXml = new System.Windows.Forms.RadioButton();
			this.rdoText = new System.Windows.Forms.RadioButton();
			this.rdoBoth = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rdoIndividual = new System.Windows.Forms.RadioButton();
			this.rdoOneBigFile = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rdoFile = new System.Windows.Forms.RadioButton();
			this.rdoDirectory = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(548, 165);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Path to MDB(s):";
			// 
			// txtMdbPath
			// 
			this.txtMdbPath.Location = new System.Drawing.Point(105, 43);
			this.txtMdbPath.Name = "txtMdbPath";
			this.txtMdbPath.Size = new System.Drawing.Size(436, 20);
			this.txtMdbPath.TabIndex = 1;
			// 
			// btnMdbPath
			// 
			this.btnMdbPath.Location = new System.Drawing.Point(548, 41);
			this.btnMdbPath.Name = "btnMdbPath";
			this.btnMdbPath.Size = new System.Drawing.Size(75, 23);
			this.btnMdbPath.TabIndex = 2;
			this.btnMdbPath.Text = "Browse";
			this.btnMdbPath.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Output Directory:";
			// 
			// txtOutputPath
			// 
			this.txtOutputPath.Location = new System.Drawing.Point(105, 69);
			this.txtOutputPath.Name = "txtOutputPath";
			this.txtOutputPath.Size = new System.Drawing.Size(436, 20);
			this.txtOutputPath.TabIndex = 3;
			// 
			// btnOutputPath
			// 
			this.btnOutputPath.Location = new System.Drawing.Point(548, 67);
			this.btnOutputPath.Name = "btnOutputPath";
			this.btnOutputPath.Size = new System.Drawing.Size(75, 23);
			this.btnOutputPath.TabIndex = 4;
			this.btnOutputPath.Text = "Browse";
			this.btnOutputPath.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(467, 165);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(263, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Note:  Existing files will be overwritten without warning.";
			// 
			// rdoXml
			// 
			this.rdoXml.AutoSize = true;
			this.rdoXml.Location = new System.Drawing.Point(215, 3);
			this.rdoXml.Name = "rdoXml";
			this.rdoXml.Size = new System.Drawing.Size(47, 17);
			this.rdoXml.TabIndex = 1;
			this.rdoXml.Text = "XML";
			this.rdoXml.UseVisualStyleBackColor = true;
			// 
			// rdoText
			// 
			this.rdoText.AutoSize = true;
			this.rdoText.Location = new System.Drawing.Point(268, 3);
			this.rdoText.Name = "rdoText";
			this.rdoText.Size = new System.Drawing.Size(131, 17);
			this.rdoText.TabIndex = 2;
			this.rdoText.Text = "Comma delimited .TXT";
			this.rdoText.UseVisualStyleBackColor = true;
			// 
			// rdoBoth
			// 
			this.rdoBoth.AutoSize = true;
			this.rdoBoth.Checked = true;
			this.rdoBoth.Location = new System.Drawing.Point(3, 3);
			this.rdoBoth.Name = "rdoBoth";
			this.rdoBoth.Size = new System.Drawing.Size(206, 17);
			this.rdoBoth.TabIndex = 0;
			this.rdoBoth.TabStop = true;
			this.rdoBoth.Text = "Both XML and Comma Dellimited .TXT";
			this.rdoBoth.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Output Format:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Output Type:";
			// 
			// rdoIndividual
			// 
			this.rdoIndividual.AutoSize = true;
			this.rdoIndividual.Location = new System.Drawing.Point(159, 5);
			this.rdoIndividual.Name = "rdoIndividual";
			this.rdoIndividual.Size = new System.Drawing.Size(130, 17);
			this.rdoIndividual.TabIndex = 1;
			this.rdoIndividual.Text = "Individual file per table";
			this.rdoIndividual.UseVisualStyleBackColor = true;
			// 
			// rdoOneBigFile
			// 
			this.rdoOneBigFile.AutoSize = true;
			this.rdoOneBigFile.Checked = true;
			this.rdoOneBigFile.Location = new System.Drawing.Point(3, 5);
			this.rdoOneBigFile.Name = "rdoOneBigFile";
			this.rdoOneBigFile.Size = new System.Drawing.Size(150, 17);
			this.rdoOneBigFile.TabIndex = 0;
			this.rdoOneBigFile.TabStop = true;
			this.rdoOneBigFile.Text = "One file including all tables";
			this.rdoOneBigFile.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.rdoIndividual);
			this.panel1.Controls.Add(this.rdoOneBigFile);
			this.panel1.Location = new System.Drawing.Point(105, 95);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 25);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.rdoXml);
			this.panel2.Controls.Add(this.rdoBoth);
			this.panel2.Controls.Add(this.rdoText);
			this.panel2.Location = new System.Drawing.Point(105, 124);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(402, 23);
			this.panel2.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(62, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Mode:";
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel3.Controls.Add(this.rdoFile);
			this.panel3.Controls.Add(this.rdoDirectory);
			this.panel3.Location = new System.Drawing.Point(105, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(212, 25);
			this.panel3.TabIndex = 0;
			// 
			// rdoFile
			// 
			this.rdoFile.AutoSize = true;
			this.rdoFile.Location = new System.Drawing.Point(120, 5);
			this.rdoFile.Name = "rdoFile";
			this.rdoFile.Size = new System.Drawing.Size(89, 17);
			this.rdoFile.TabIndex = 1;
			this.rdoFile.Text = "Individual File";
			this.rdoFile.UseVisualStyleBackColor = true;
			// 
			// rdoDirectory
			// 
			this.rdoDirectory.AutoSize = true;
			this.rdoDirectory.Checked = true;
			this.rdoDirectory.Location = new System.Drawing.Point(3, 5);
			this.rdoDirectory.Name = "rdoDirectory";
			this.rdoDirectory.Size = new System.Drawing.Size(111, 17);
			this.rdoDirectory.TabIndex = 0;
			this.rdoDirectory.TabStop = true;
			this.rdoDirectory.Text = "All files in directory";
			this.rdoDirectory.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(635, 200);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOutputPath);
			this.Controls.Add(this.btnMdbPath);
			this.Controls.Add(this.txtOutputPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMdbPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOK);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "MDB to Text Converter";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMdbPath;
    private System.Windows.Forms.Button btnMdbPath;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtOutputPath;
    private System.Windows.Forms.Button btnOutputPath;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton rdoXml;
    private System.Windows.Forms.RadioButton rdoText;
    private System.Windows.Forms.RadioButton rdoBoth;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.RadioButton rdoIndividual;
    private System.Windows.Forms.RadioButton rdoOneBigFile;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rdoFile;
		private System.Windows.Forms.RadioButton rdoDirectory;
  }
}

