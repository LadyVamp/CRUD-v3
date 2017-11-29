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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSetTFileWithoutID = new CRUD_v3.SearchBaseDataSetTFileWithoutID();
            this.tFileTableAdapter = new CRUD_v3.SearchBaseDataSetTFileWithoutIDTableAdapters.TFileTableAdapter();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.rbDoc = new MetroFramework.Controls.MetroRadioButton();
            this.rbTxt = new MetroFramework.Controls.MetroRadioButton();
            this.rbDocx = new MetroFramework.Controls.MetroRadioButton();
            this.rbRtf = new MetroFramework.Controls.MetroRadioButton();
            this.panelFormats = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnCallFormLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.txtMinSize = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSizeFilter = new MetroFramework.Controls.MetroButton();
            this.searchBaseTFileNewWithoutID = new CRUD_v3.SearchBaseTFileNewWithoutID();
            this.tFileNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFileNewTableAdapter = new CRUD_v3.SearchBaseTFileNewWithoutIDTableAdapters.TFileNewTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filecontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCatalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileWithoutID)).BeginInit();
            this.panelFormats.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseTFileNewWithoutID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileNewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(621, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 39);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.filecontentDataGridViewTextBoxColumn,
            this.idCatalogDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.tFileNewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.White;
            this.metroGrid1.Location = new System.Drawing.Point(23, 236);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(657, 242);
            this.metroGrid1.TabIndex = 2;
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
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(557, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(23, 72);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(595, 39);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.UseStyleColors = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // rbDoc
            // 
            this.rbDoc.Location = new System.Drawing.Point(13, 38);
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
            this.rbTxt.Location = new System.Drawing.Point(13, 71);
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
            this.rbDocx.Location = new System.Drawing.Point(73, 38);
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
            this.rbRtf.Location = new System.Drawing.Point(73, 71);
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
            this.panelFormats.Controls.Add(this.metroLabel5);
            this.panelFormats.Controls.Add(this.rbRtf);
            this.panelFormats.Controls.Add(this.rbDocx);
            this.panelFormats.Controls.Add(this.rbTxt);
            this.panelFormats.Controls.Add(this.rbDoc);
            this.panelFormats.HorizontalScrollbarBarColor = true;
            this.panelFormats.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFormats.HorizontalScrollbarSize = 10;
            this.panelFormats.Location = new System.Drawing.Point(23, 116);
            this.panelFormats.Name = "panelFormats";
            this.panelFormats.Size = new System.Drawing.Size(160, 105);
            this.panelFormats.TabIndex = 14;
            this.panelFormats.VerticalScrollbarBarColor = true;
            this.panelFormats.VerticalScrollbarHighlightOnWheel = false;
            this.panelFormats.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 20);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Формат";
            // 
            // btnCallFormLogin
            // 
            this.btnCallFormLogin.Location = new System.Drawing.Point(472, 484);
            this.btnCallFormLogin.Name = "btnCallFormLogin";
            this.btnCallFormLogin.Size = new System.Drawing.Size(208, 23);
            this.btnCallFormLogin.TabIndex = 15;
            this.btnCallFormLogin.Text = "Вход для администратора";
            this.btnCallFormLogin.UseSelectable = true;
            this.btnCallFormLogin.Click += new System.EventHandler(this.btnCallFormLogin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(110, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 17);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "кБ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(108, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 17);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "кБ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtMaxSize);
            this.metroPanel1.Controls.Add(this.txtMinSize);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(189, 116);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(153, 105);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxSize.Location = new System.Drawing.Point(40, 68);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(62, 22);
            this.txtMaxSize.TabIndex = 24;
            // 
            // txtMinSize
            // 
            this.txtMinSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinSize.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMinSize.Location = new System.Drawing.Point(40, 38);
            this.txtMinSize.Name = "txtMinSize";
            this.txtMinSize.Size = new System.Drawing.Size(62, 22);
            this.txtMinSize.TabIndex = 22;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 20);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Размер";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(11, 73);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 17);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "До";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(11, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(23, 17);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "От";
            // 
            // btnSizeFilter
            // 
            this.btnSizeFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSizeFilter.ForeColor = System.Drawing.Color.Navy;
            this.btnSizeFilter.Location = new System.Drawing.Point(348, 154);
            this.btnSizeFilter.Name = "btnSizeFilter";
            this.btnSizeFilter.Size = new System.Drawing.Size(166, 31);
            this.btnSizeFilter.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSizeFilter.TabIndex = 21;
            this.btnSizeFilter.Text = "Применить фильтр";
            this.btnSizeFilter.UseCustomForeColor = true;
            this.btnSizeFilter.UseSelectable = true;
            this.btnSizeFilter.UseStyleColors = true;
            this.btnSizeFilter.Click += new System.EventHandler(this.btnSizeFilter_Click);
            // 
            // searchBaseTFileNewWithoutID
            // 
            this.searchBaseTFileNewWithoutID.DataSetName = "SearchBaseTFileNewWithoutID";
            this.searchBaseTFileNewWithoutID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFileNewBindingSource
            // 
            this.tFileNewBindingSource.DataMember = "TFileNew";
            this.tFileNewBindingSource.DataSource = this.searchBaseTFileNewWithoutID;
            // 
            // tFileNewTableAdapter
            // 
            this.tFileNewTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "keywords";
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            // 
            // filecontentDataGridViewTextBoxColumn
            // 
            this.filecontentDataGridViewTextBoxColumn.DataPropertyName = "filecontent";
            this.filecontentDataGridViewTextBoxColumn.HeaderText = "filecontent";
            this.filecontentDataGridViewTextBoxColumn.Name = "filecontentDataGridViewTextBoxColumn";
            // 
            // idCatalogDataGridViewTextBoxColumn
            // 
            this.idCatalogDataGridViewTextBoxColumn.DataPropertyName = "IdCatalog";
            this.idCatalogDataGridViewTextBoxColumn.HeaderText = "IdCatalog";
            this.idCatalogDataGridViewTextBoxColumn.Name = "idCatalogDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(699, 530);
            this.Controls.Add(this.btnSizeFilter);
            this.Controls.Add(this.metroPanel1);
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
            this.panelFormats.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseTFileNewWithoutID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileNewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private SearchBaseDataSetTFileWithoutID searchBaseDataSetTFileWithoutID;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private SearchBaseDataSetTFileWithoutIDTableAdapters.TFileTableAdapter tFileTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroRadioButton rbDoc;
        private MetroFramework.Controls.MetroRadioButton rbTxt;
        private MetroFramework.Controls.MetroRadioButton rbDocx;
        private MetroFramework.Controls.MetroRadioButton rbRtf;
        private MetroFramework.Controls.MetroPanel panelFormats;
        private MetroFramework.Controls.MetroButton btnCallFormLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSizeFilter;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.TextBox txtMinSize;
        private SearchBaseTFileNewWithoutID searchBaseTFileNewWithoutID;
        private System.Windows.Forms.BindingSource tFileNewBindingSource;
        private SearchBaseTFileNewWithoutIDTableAdapters.TFileNewTableAdapter tFileNewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filecontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCatalogDataGridViewTextBoxColumn;
    }
}

