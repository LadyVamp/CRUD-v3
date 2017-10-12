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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.rbDoc = new MetroFramework.Controls.MetroRadioButton();
            this.rbTxt = new MetroFramework.Controls.MetroRadioButton();
            this.rbDocx = new MetroFramework.Controls.MetroRadioButton();
            this.rbRtf = new MetroFramework.Controls.MetroRadioButton();
            this.panelFormats = new MetroFramework.Controls.MetroPanel();
            this.btnCallFormLogin = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileWithoutID)).BeginInit();
            this.panelFormats.SuspendLayout();
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.tFileBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.White;
            this.metroGrid1.Location = new System.Drawing.Point(23, 212);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(726, 242);
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
            // rbDoc
            // 
            this.rbDoc.Location = new System.Drawing.Point(14, 12);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(70, 25);
            this.rbDoc.Style = MetroFramework.MetroColorStyle.Black;
            this.rbDoc.TabIndex = 10;
            this.rbDoc.Text = ".doc";
            this.rbDoc.UseSelectable = true;
            this.rbDoc.UseStyleColors = true;
            this.rbDoc.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged);
            // 
            // rbTxt
            // 
            this.rbTxt.Location = new System.Drawing.Point(14, 45);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(70, 25);
            this.rbTxt.Style = MetroFramework.MetroColorStyle.Black;
            this.rbTxt.TabIndex = 11;
            this.rbTxt.Text = ".txt";
            this.rbTxt.UseSelectable = true;
            this.rbTxt.UseStyleColors = true;
            this.rbTxt.CheckedChanged += new System.EventHandler(this.rbTxt_CheckedChanged);
            // 
            // rbDocx
            // 
            this.rbDocx.Location = new System.Drawing.Point(102, 12);
            this.rbDocx.Name = "rbDocx";
            this.rbDocx.Size = new System.Drawing.Size(70, 25);
            this.rbDocx.Style = MetroFramework.MetroColorStyle.Black;
            this.rbDocx.TabIndex = 12;
            this.rbDocx.Text = ".docx";
            this.rbDocx.UseSelectable = true;
            this.rbDocx.UseStyleColors = true;
            this.rbDocx.CheckedChanged += new System.EventHandler(this.rbDocx_CheckedChanged);
            // 
            // rbRtf
            // 
            this.rbRtf.Location = new System.Drawing.Point(102, 43);
            this.rbRtf.Name = "rbRtf";
            this.rbRtf.Size = new System.Drawing.Size(70, 25);
            this.rbRtf.Style = MetroFramework.MetroColorStyle.Black;
            this.rbRtf.TabIndex = 13;
            this.rbRtf.Text = ".rtf";
            this.rbRtf.UseSelectable = true;
            this.rbRtf.UseStyleColors = true;
            this.rbRtf.CheckedChanged += new System.EventHandler(this.rbRtf_CheckedChanged);
            // 
            // panelFormats
            // 
            this.panelFormats.Controls.Add(this.rbRtf);
            this.panelFormats.Controls.Add(this.rbDocx);
            this.panelFormats.Controls.Add(this.rbTxt);
            this.panelFormats.Controls.Add(this.rbDoc);
            this.panelFormats.HorizontalScrollbarBarColor = true;
            this.panelFormats.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFormats.HorizontalScrollbarSize = 10;
            this.panelFormats.Location = new System.Drawing.Point(23, 127);
            this.panelFormats.Name = "panelFormats";
            this.panelFormats.Size = new System.Drawing.Size(200, 79);
            this.panelFormats.TabIndex = 14;
            this.panelFormats.VerticalScrollbarBarColor = true;
            this.panelFormats.VerticalScrollbarHighlightOnWheel = false;
            this.panelFormats.VerticalScrollbarSize = 10;
            // 
            // btnCallFormLogin
            // 
            this.btnCallFormLogin.Location = new System.Drawing.Point(541, 469);
            this.btnCallFormLogin.Name = "btnCallFormLogin";
            this.btnCallFormLogin.Size = new System.Drawing.Size(208, 23);
            this.btnCallFormLogin.TabIndex = 15;
            this.btnCallFormLogin.Text = "Вход для администратора";
            this.btnCallFormLogin.UseSelectable = true;
            this.btnCallFormLogin.Click += new System.EventHandler(this.btnCallFormLogin_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(772, 515);
            this.Controls.Add(this.btnCallFormLogin);
            this.Controls.Add(this.panelFormats);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.DarkBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileWithoutID)).EndInit();
            this.panelFormats.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private MetroFramework.Controls.MetroRadioButton rbDoc;
        private MetroFramework.Controls.MetroRadioButton rbTxt;
        private MetroFramework.Controls.MetroRadioButton rbDocx;
        private MetroFramework.Controls.MetroRadioButton rbRtf;
        private MetroFramework.Controls.MetroPanel panelFormats;
        private MetroFramework.Controls.MetroButton btnCallFormLogin;
    }
}

