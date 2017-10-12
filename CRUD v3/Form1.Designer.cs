namespace CRUD_v3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSetTFileWithoutID = new CRUD_v3.SearchBaseDataSetTFileWithoutID();
            this.tFileTableAdapter = new CRUD_v3.SearchBaseDataSetTFileWithoutIDTableAdapters.TFileTableAdapter();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.cbDoc = new MetroFramework.Controls.MetroCheckBox();
            this.cbDocx = new MetroFramework.Controls.MetroCheckBox();
            this.cbTxt = new MetroFramework.Controls.MetroCheckBox();
            this.cbRtf = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileWithoutID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(218, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 26);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.tFileBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.White;
            this.metroGrid1.Location = new System.Drawing.Point(23, 212);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(746, 242);
            this.metroGrid1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "Ключевые слова";
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Размер, кБ";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Формат";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Содержание";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // tFileBindingSource
            // 
            this.tFileBindingSource.DataMember = "TFile";
            this.tFileBindingSource.DataSource = this.searchBaseDataSetTFileWithoutID;
            // 
            // searchBaseDataSetTFileWithoutID
            // 
            this.searchBaseDataSetTFileWithoutID.DataSetName = "SearchBaseDataSetTFileWithoutID";
            this.searchBaseDataSetTFileWithoutID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFileTableAdapter
            // 
            this.tFileTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(169, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(23, 84);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Введите название";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.UseStyleColors = true;
            this.txtSearch.WaterMark = "Введите название";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbDoc
            // 
            this.cbDoc.AutoSize = true;
            this.cbDoc.Location = new System.Drawing.Point(23, 139);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(49, 17);
            this.cbDoc.TabIndex = 6;
            this.cbDoc.Text = ".doc";
            this.cbDoc.UseSelectable = true;
            this.cbDoc.CheckedChanged += new System.EventHandler(this.cbDoc_CheckedChanged);
            // 
            // cbDocx
            // 
            this.cbDocx.AutoSize = true;
            this.cbDocx.Location = new System.Drawing.Point(98, 139);
            this.cbDocx.Name = "cbDocx";
            this.cbDocx.Size = new System.Drawing.Size(55, 17);
            this.cbDocx.TabIndex = 7;
            this.cbDocx.Text = ".docx";
            this.cbDocx.UseSelectable = true;
            this.cbDocx.CheckedChanged += new System.EventHandler(this.cbDocx_CheckedChanged);
            // 
            // cbTxt
            // 
            this.cbTxt.AutoSize = true;
            this.cbTxt.Location = new System.Drawing.Point(23, 172);
            this.cbTxt.Name = "cbTxt";
            this.cbTxt.Size = new System.Drawing.Size(41, 17);
            this.cbTxt.TabIndex = 8;
            this.cbTxt.Text = ".txt";
            this.cbTxt.UseSelectable = true;
            this.cbTxt.CheckedChanged += new System.EventHandler(this.cbTxt_CheckedChanged);
            // 
            // cbRtf
            // 
            this.cbRtf.AutoSize = true;
            this.cbRtf.Location = new System.Drawing.Point(98, 172);
            this.cbRtf.Name = "cbRtf";
            this.cbRtf.Size = new System.Drawing.Size(40, 17);
            this.cbRtf.TabIndex = 9;
            this.cbRtf.Text = ".rtf";
            this.cbRtf.UseSelectable = true;
            this.cbRtf.CheckedChanged += new System.EventHandler(this.cbRtf_CheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.Controls.Add(this.cbRtf);
            this.Controls.Add(this.cbTxt);
            this.Controls.Add(this.cbDocx);
            this.Controls.Add(this.cbDoc);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.DarkBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileWithoutID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private SearchBaseDataSetTFileWithoutID searchBaseDataSetTFileWithoutID;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private SearchBaseDataSetTFileWithoutIDTableAdapters.TFileTableAdapter tFileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroCheckBox cbDoc;
        private MetroFramework.Controls.MetroCheckBox cbDocx;
        private MetroFramework.Controls.MetroCheckBox cbTxt;
        private MetroFramework.Controls.MetroCheckBox cbRtf;
    }
}

