namespace CRUD_v3
{
    partial class AddEditFile
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFileID = new MetroFramework.Controls.MetroTextBox();
            this.txtFileName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtKeywords = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSize = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbFormat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.btnSaveFile = new MetroFramework.Controls.MetroButton();
            this.bindingSourceFile = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCatalog = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFile)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "File ID";
            // 
            // txtFileID
            // 
            // 
            // 
            // 
            this.txtFileID.CustomButton.Image = null;
            this.txtFileID.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtFileID.CustomButton.Name = "";
            this.txtFileID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFileID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileID.CustomButton.TabIndex = 1;
            this.txtFileID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileID.CustomButton.UseSelectable = true;
            this.txtFileID.CustomButton.Visible = false;
            this.txtFileID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "ID", true));
            this.txtFileID.Lines = new string[0];
            this.txtFileID.Location = new System.Drawing.Point(126, 85);
            this.txtFileID.MaxLength = 32767;
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.PasswordChar = '\0';
            this.txtFileID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileID.SelectedText = "";
            this.txtFileID.SelectionLength = 0;
            this.txtFileID.SelectionStart = 0;
            this.txtFileID.ShortcutsEnabled = true;
            this.txtFileID.Size = new System.Drawing.Size(93, 23);
            this.txtFileID.TabIndex = 1;
            this.txtFileID.UseSelectable = true;
            this.txtFileID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFileName
            // 
            // 
            // 
            // 
            this.txtFileName.CustomButton.Image = null;
            this.txtFileName.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtFileName.CustomButton.Name = "";
            this.txtFileName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileName.CustomButton.TabIndex = 1;
            this.txtFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileName.CustomButton.UseSelectable = true;
            this.txtFileName.CustomButton.Visible = false;
            this.txtFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "name", true));
            this.txtFileName.Lines = new string[0];
            this.txtFileName.Location = new System.Drawing.Point(126, 123);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileName.SelectedText = "";
            this.txtFileName.SelectionLength = 0;
            this.txtFileName.SelectionStart = 0;
            this.txtFileName.ShortcutsEnabled = true;
            this.txtFileName.Size = new System.Drawing.Size(314, 23);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name";
            // 
            // txtKeywords
            // 
            // 
            // 
            // 
            this.txtKeywords.CustomButton.Image = null;
            this.txtKeywords.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtKeywords.CustomButton.Name = "";
            this.txtKeywords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKeywords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeywords.CustomButton.TabIndex = 1;
            this.txtKeywords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeywords.CustomButton.UseSelectable = true;
            this.txtKeywords.CustomButton.Visible = false;
            this.txtKeywords.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "keywords", true));
            this.txtKeywords.Lines = new string[0];
            this.txtKeywords.Location = new System.Drawing.Point(126, 163);
            this.txtKeywords.MaxLength = 32767;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.PasswordChar = '\0';
            this.txtKeywords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeywords.SelectedText = "";
            this.txtKeywords.SelectionLength = 0;
            this.txtKeywords.SelectionStart = 0;
            this.txtKeywords.ShortcutsEnabled = true;
            this.txtKeywords.Size = new System.Drawing.Size(314, 23);
            this.txtKeywords.TabIndex = 5;
            this.txtKeywords.UseSelectable = true;
            this.txtKeywords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeywords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Keywords";
            // 
            // txtSize
            // 
            // 
            // 
            // 
            this.txtSize.CustomButton.Image = null;
            this.txtSize.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtSize.CustomButton.Name = "";
            this.txtSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSize.CustomButton.TabIndex = 1;
            this.txtSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSize.CustomButton.UseSelectable = true;
            this.txtSize.CustomButton.Visible = false;
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "size", true));
            this.txtSize.Lines = new string[0];
            this.txtSize.Location = new System.Drawing.Point(126, 203);
            this.txtSize.MaxLength = 32767;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSize.SelectedText = "";
            this.txtSize.SelectionLength = 0;
            this.txtSize.SelectionStart = 0;
            this.txtSize.ShortcutsEnabled = true;
            this.txtSize.Size = new System.Drawing.Size(93, 23);
            this.txtSize.TabIndex = 7;
            this.txtSize.UseSelectable = true;
            this.txtSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 206);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Size";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 243);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Format";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "format", true));
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.ItemHeight = 24;
            this.cmbFormat.Location = new System.Drawing.Point(126, 243);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(93, 30);
            this.cmbFormat.TabIndex = 10;
            this.cmbFormat.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(48, 287);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 20);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Content";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(48, 366);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 20);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "IdCatalog";
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "content", true));
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(126, 287);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(314, 70);
            this.metroTextBox6.TabIndex = 5;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(382, 399);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 16;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseSelectable = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // bindingSourceFile
            // 
            this.bindingSourceFile.DataSource = typeof(CRUD_v3.TFile);
            // 
            // cmbCatalog
            // 
            this.cmbCatalog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFile, "IdCatalog", true));
            this.cmbCatalog.FormattingEnabled = true;
            this.cmbCatalog.ItemHeight = 24;
            this.cmbCatalog.Location = new System.Drawing.Point(126, 366);
            this.cmbCatalog.Name = "cmbCatalog";
            this.cmbCatalog.Size = new System.Drawing.Size(93, 30);
            this.cmbCatalog.TabIndex = 17;
            this.cmbCatalog.UseSelectable = true;
            // 
            // AddEditFile
            // 
            this.AcceptButton = this.btnSaveFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(501, 438);
            this.Controls.Add(this.cmbCatalog);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox6);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFileID);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditFile";
            this.Resizable = false;
            this.Text = "File Info";
            this.Load += new System.EventHandler(this.AddEditFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFileID;
        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtKeywords;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSize;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbFormat;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroButton btnSaveFile;
        private System.Windows.Forms.BindingSource bindingSourceFile;
        private MetroFramework.Controls.MetroComboBox cmbCatalog;
    }
}