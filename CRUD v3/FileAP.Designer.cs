namespace CRUD_v3
{
    partial class FileAP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileAP));
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cmbFormat = new MetroFramework.Controls.MetroComboBox();
            this.txtKeywords = new MetroFramework.Controls.MetroTextBox();
            this.txtFileName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.FileGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnDelFile = new MetroFramework.Controls.MetroButton();
            this.btnViewFile = new MetroFramework.Controls.MetroButton();
            this.btnUpdFile = new MetroFramework.Controls.MetroButton();
            this.btnSaveFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbCatalog = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FileGrid)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(165, 244);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(160, 54);
            this.txtContent.TabIndex = 23;
            this.txtContent.Text = "";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(165, 177);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(57, 22);
            this.txtSize.TabIndex = 22;
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.ItemHeight = 24;
            this.cmbFormat.Items.AddRange(new object[] {
            ".doc",
            ".docx",
            ".txt",
            ".rtf"});
            this.cmbFormat.Location = new System.Drawing.Point(165, 205);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(160, 30);
            this.cmbFormat.TabIndex = 20;
            this.cmbFormat.UseSelectable = true;
            // 
            // txtKeywords
            // 
            // 
            // 
            // 
            this.txtKeywords.CustomButton.Image = null;
            this.txtKeywords.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtKeywords.CustomButton.Name = "";
            this.txtKeywords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKeywords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeywords.CustomButton.TabIndex = 1;
            this.txtKeywords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtKeywords.CustomButton.UseSelectable = true;
            this.txtKeywords.CustomButton.Visible = false;
            this.txtKeywords.DisplayIcon = true;
            this.txtKeywords.Lines = new string[0];
            this.txtKeywords.Location = new System.Drawing.Point(165, 136);
            this.txtKeywords.Margin = new System.Windows.Forms.Padding(5);
            this.txtKeywords.MaxLength = 32767;
            this.txtKeywords.Multiline = true;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.PasswordChar = '\0';
            this.txtKeywords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeywords.SelectedText = "";
            this.txtKeywords.SelectionLength = 0;
            this.txtKeywords.SelectionStart = 0;
            this.txtKeywords.ShortcutsEnabled = true;
            this.txtKeywords.ShowClearButton = true;
            this.txtKeywords.Size = new System.Drawing.Size(160, 26);
            this.txtKeywords.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeywords.TabIndex = 21;
            this.txtKeywords.UseCustomBackColor = true;
            this.txtKeywords.UseSelectable = true;
            this.txtKeywords.UseStyleColors = true;
            this.txtKeywords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeywords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtFileName
            // 
            // 
            // 
            // 
            this.txtFileName.CustomButton.Image = null;
            this.txtFileName.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtFileName.CustomButton.Name = "";
            this.txtFileName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileName.CustomButton.TabIndex = 1;
            this.txtFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFileName.CustomButton.UseSelectable = true;
            this.txtFileName.CustomButton.Visible = false;
            this.txtFileName.DisplayIcon = true;
            this.txtFileName.Lines = new string[0];
            this.txtFileName.Location = new System.Drawing.Point(165, 102);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileName.SelectedText = "";
            this.txtFileName.SelectionLength = 0;
            this.txtFileName.SelectionStart = 0;
            this.txtFileName.ShortcutsEnabled = true;
            this.txtFileName.ShowClearButton = true;
            this.txtFileName.Size = new System.Drawing.Size(160, 26);
            this.txtFileName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileName.TabIndex = 19;
            this.txtFileName.UseCustomBackColor = true;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.UseStyleColors = true;
            this.txtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 244);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(94, 20);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Cодержимое";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 211);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 20);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Формат";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(24, 171);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 20);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Размер";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(24, 136);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 20);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Ключевые слова";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 102);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 20);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Название";
            // 
            // FileGrid
            // 
            this.FileGrid.AllowUserToResizeRows = false;
            this.FileGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileGrid.EnableHeadersVisualStyles = false;
            this.FileGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileGrid.Location = new System.Drawing.Point(340, 102);
            this.FileGrid.Name = "FileGrid";
            this.FileGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FileGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FileGrid.RowTemplate.Height = 24;
            this.FileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileGrid.Size = new System.Drawing.Size(519, 338);
            this.FileGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.FileGrid.TabIndex = 24;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.btnDelFile);
            this.metroPanel3.Controls.Add(this.btnViewFile);
            this.metroPanel3.Controls.Add(this.btnUpdFile);
            this.metroPanel3.Controls.Add(this.btnSaveFile);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(23, 356);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(302, 122);
            this.metroPanel3.TabIndex = 25;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnDelFile
            // 
            this.btnDelFile.BackColor = System.Drawing.Color.Teal;
            this.btnDelFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelFile.BackgroundImage")));
            this.btnDelFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelFile.ForeColor = System.Drawing.Color.White;
            this.btnDelFile.Location = new System.Drawing.Point(149, 5);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(103, 30);
            this.btnDelFile.TabIndex = 8;
            this.btnDelFile.Text = "  Delete";
            this.btnDelFile.UseCustomBackColor = true;
            this.btnDelFile.UseCustomForeColor = true;
            this.btnDelFile.UseSelectable = true;
            this.btnDelFile.UseStyleColors = true;
            // 
            // btnViewFile
            // 
            this.btnViewFile.BackColor = System.Drawing.Color.Teal;
            this.btnViewFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewFile.BackgroundImage")));
            this.btnViewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewFile.ForeColor = System.Drawing.Color.White;
            this.btnViewFile.Location = new System.Drawing.Point(15, 82);
            this.btnViewFile.Name = "btnViewFile";
            this.btnViewFile.Size = new System.Drawing.Size(103, 30);
            this.btnViewFile.TabIndex = 7;
            this.btnViewFile.Text = " View";
            this.btnViewFile.UseCustomBackColor = true;
            this.btnViewFile.UseCustomForeColor = true;
            this.btnViewFile.UseSelectable = true;
            this.btnViewFile.UseStyleColors = true;
            // 
            // btnUpdFile
            // 
            this.btnUpdFile.BackColor = System.Drawing.Color.Teal;
            this.btnUpdFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdFile.BackgroundImage")));
            this.btnUpdFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdFile.ForeColor = System.Drawing.Color.White;
            this.btnUpdFile.Location = new System.Drawing.Point(15, 41);
            this.btnUpdFile.Name = "btnUpdFile";
            this.btnUpdFile.Size = new System.Drawing.Size(103, 30);
            this.btnUpdFile.TabIndex = 6;
            this.btnUpdFile.Text = "  Update";
            this.btnUpdFile.UseCustomBackColor = true;
            this.btnUpdFile.UseCustomForeColor = true;
            this.btnUpdFile.UseSelectable = true;
            this.btnUpdFile.UseStyleColors = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.Teal;
            this.btnSaveFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.BackgroundImage")));
            this.btnSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Location = new System.Drawing.Point(15, 5);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(103, 30);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = " Insert";
            this.btnSaveFile.UseCustomBackColor = true;
            this.btnSaveFile.UseCustomForeColor = true;
            this.btnSaveFile.UseSelectable = true;
            this.btnSaveFile.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(24, 304);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(80, 20);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "ID каталога";
            // 
            // cmbCatalog
            // 
            this.cmbCatalog.FormattingEnabled = true;
            this.cmbCatalog.ItemHeight = 24;
            this.cmbCatalog.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCatalog.Location = new System.Drawing.Point(163, 304);
            this.cmbCatalog.Name = "cmbCatalog";
            this.cmbCatalog.Size = new System.Drawing.Size(59, 30);
            this.cmbCatalog.TabIndex = 27;
            this.cmbCatalog.UseSelectable = true;
            // 
            // FileAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 501);
            this.Controls.Add(this.cmbCatalog);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.FileGrid);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileAP";
            this.Resizable = false;
            this.Text = "FileAP";
            ((System.ComponentModel.ISupportInitialize)(this.FileGrid)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.TextBox txtSize;
        private MetroFramework.Controls.MetroComboBox cmbFormat;
        private MetroFramework.Controls.MetroTextBox txtKeywords;
        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid FileGrid;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnDelFile;
        private MetroFramework.Controls.MetroButton btnViewFile;
        private MetroFramework.Controls.MetroButton btnUpdFile;
        private MetroFramework.Controls.MetroButton btnSaveFile;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbCatalog;
    }
}