namespace CRUD_v3
{
    partial class MainAP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAP));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.SearchPatternGrid = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularExpressionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compareWithDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSearchPatternBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSetTSearchPattern = new CRUD_v3.SearchBaseDataSetTSearchPattern();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSaveSP = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbAction = new MetroFramework.Controls.MetroComboBox();
            this.cmbCompare = new MetroFramework.Controls.MetroComboBox();
            this.txtRegExp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tSearchPatternTableAdapter = new CRUD_v3.SearchBaseDataSetTSearchPatternTableAdapters.TSearchPatternTableAdapter();
            this.btnUpdSP = new MetroFramework.Controls.MetroButton();
            this.btnViewSP = new MetroFramework.Controls.MetroButton();
            this.btnDelSP = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPatternGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTSearchPattern)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(160, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Панель администратора";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(30, 108);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(863, 434);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Tag = "";
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.SearchPatternGrid);
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(855, 392);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Шаблоны поиска";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // SearchPatternGrid
            // 
            this.SearchPatternGrid.AllowUserToResizeRows = false;
            this.SearchPatternGrid.AutoGenerateColumns = false;
            this.SearchPatternGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchPatternGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchPatternGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SearchPatternGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchPatternGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.SearchPatternGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchPatternGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.regularExpressionDataGridViewTextBoxColumn,
            this.compareWithDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.SearchPatternGrid.DataSource = this.tSearchPatternBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchPatternGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.SearchPatternGrid.EnableHeadersVisualStyles = false;
            this.SearchPatternGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchPatternGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SearchPatternGrid.Location = new System.Drawing.Point(4, 193);
            this.SearchPatternGrid.Name = "SearchPatternGrid";
            this.SearchPatternGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchPatternGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.SearchPatternGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SearchPatternGrid.RowTemplate.Height = 24;
            this.SearchPatternGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchPatternGrid.Size = new System.Drawing.Size(703, 150);
            this.SearchPatternGrid.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regularExpressionDataGridViewTextBoxColumn
            // 
            this.regularExpressionDataGridViewTextBoxColumn.DataPropertyName = "RegularExpression";
            this.regularExpressionDataGridViewTextBoxColumn.HeaderText = "RegularExpression";
            this.regularExpressionDataGridViewTextBoxColumn.Name = "regularExpressionDataGridViewTextBoxColumn";
            // 
            // compareWithDataGridViewTextBoxColumn
            // 
            this.compareWithDataGridViewTextBoxColumn.DataPropertyName = "CompareWith";
            this.compareWithDataGridViewTextBoxColumn.HeaderText = "CompareWith";
            this.compareWithDataGridViewTextBoxColumn.Name = "compareWithDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // tSearchPatternBindingSource
            // 
            this.tSearchPatternBindingSource.DataMember = "TSearchPattern";
            this.tSearchPatternBindingSource.DataSource = this.searchBaseDataSetTSearchPattern;
            // 
            // searchBaseDataSetTSearchPattern
            // 
            this.searchBaseDataSetTSearchPattern.DataSetName = "SearchBaseDataSetTSearchPattern";
            this.searchBaseDataSetTSearchPattern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnDelSP);
            this.metroPanel2.Controls.Add(this.btnViewSP);
            this.metroPanel2.Controls.Add(this.btnUpdSP);
            this.metroPanel2.Controls.Add(this.btnSaveSP);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(578, 30);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(256, 140);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSaveSP
            // 
            this.btnSaveSP.BackColor = System.Drawing.Color.Orange;
            this.btnSaveSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSP.BackgroundImage")));
            this.btnSaveSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveSP.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSP.Location = new System.Drawing.Point(15, 13);
            this.btnSaveSP.Name = "btnSaveSP";
            this.btnSaveSP.Size = new System.Drawing.Size(103, 30);
            this.btnSaveSP.TabIndex = 2;
            this.btnSaveSP.Text = " Save";
            this.btnSaveSP.UseCustomBackColor = true;
            this.btnSaveSP.UseCustomForeColor = true;
            this.btnSaveSP.UseSelectable = true;
            this.btnSaveSP.UseStyleColors = true;
            this.btnSaveSP.Click += new System.EventHandler(this.btnSaveSP_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cmbAction);
            this.metroPanel1.Controls.Add(this.cmbCompare);
            this.metroPanel1.Controls.Add(this.txtRegExp);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(528, 140);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmbAction
            // 
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.ItemHeight = 24;
            this.cmbAction.Items.AddRange(new object[] {
            "Включить",
            "Исключить"});
            this.cmbAction.Location = new System.Drawing.Point(322, 92);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(183, 30);
            this.cmbAction.TabIndex = 8;
            this.cmbAction.UseSelectable = true;
            // 
            // cmbCompare
            // 
            this.cmbCompare.FormattingEnabled = true;
            this.cmbCompare.ItemHeight = 24;
            this.cmbCompare.Items.AddRange(new object[] {
            "Имя файла",
            "Абсолютный путь"});
            this.cmbCompare.Location = new System.Drawing.Point(322, 52);
            this.cmbCompare.Name = "cmbCompare";
            this.cmbCompare.Size = new System.Drawing.Size(183, 30);
            this.cmbCompare.TabIndex = 7;
            this.cmbCompare.UseSelectable = true;
            // 
            // txtRegExp
            // 
            // 
            // 
            // 
            this.txtRegExp.CustomButton.Image = null;
            this.txtRegExp.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtRegExp.CustomButton.Name = "";
            this.txtRegExp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRegExp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegExp.CustomButton.TabIndex = 1;
            this.txtRegExp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRegExp.CustomButton.UseSelectable = true;
            this.txtRegExp.CustomButton.Visible = false;
            this.txtRegExp.DisplayIcon = true;
            this.txtRegExp.Lines = new string[0];
            this.txtRegExp.Location = new System.Drawing.Point(322, 7);
            this.txtRegExp.Margin = new System.Windows.Forms.Padding(5);
            this.txtRegExp.MaxLength = 32767;
            this.txtRegExp.Multiline = true;
            this.txtRegExp.Name = "txtRegExp";
            this.txtRegExp.PasswordChar = '\0';
            this.txtRegExp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegExp.SelectedText = "";
            this.txtRegExp.SelectionLength = 0;
            this.txtRegExp.SelectionStart = 0;
            this.txtRegExp.ShortcutsEnabled = true;
            this.txtRegExp.ShowClearButton = true;
            this.txtRegExp.Size = new System.Drawing.Size(183, 26);
            this.txtRegExp.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegExp.TabIndex = 6;
            this.txtRegExp.UseCustomBackColor = true;
            this.txtRegExp.UseSelectable = true;
            this.txtRegExp.UseStyleColors = true;
            this.txtRegExp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegExp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Действие";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Сравнивать с ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(225, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Шаблон (регулярное выражение)";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.metroTabPage2.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(855, 392);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Файлы";
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.UseCustomForeColor = true;
            this.metroTabPage2.UseStyleColors = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tSearchPatternTableAdapter
            // 
            this.tSearchPatternTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdSP
            // 
            this.btnUpdSP.BackColor = System.Drawing.Color.Orange;
            this.btnUpdSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdSP.BackgroundImage")));
            this.btnUpdSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdSP.ForeColor = System.Drawing.Color.Black;
            this.btnUpdSP.Location = new System.Drawing.Point(15, 52);
            this.btnUpdSP.Name = "btnUpdSP";
            this.btnUpdSP.Size = new System.Drawing.Size(103, 30);
            this.btnUpdSP.TabIndex = 6;
            this.btnUpdSP.Text = " Update";
            this.btnUpdSP.UseCustomBackColor = true;
            this.btnUpdSP.UseCustomForeColor = true;
            this.btnUpdSP.UseSelectable = true;
            this.btnUpdSP.UseStyleColors = true;
            this.btnUpdSP.Click += new System.EventHandler(this.btnUpdSP_Click);
            // 
            // btnViewSP
            // 
            this.btnViewSP.BackColor = System.Drawing.Color.Orange;
            this.btnViewSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewSP.BackgroundImage")));
            this.btnViewSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewSP.ForeColor = System.Drawing.Color.Black;
            this.btnViewSP.Location = new System.Drawing.Point(15, 92);
            this.btnViewSP.Name = "btnViewSP";
            this.btnViewSP.Size = new System.Drawing.Size(103, 30);
            this.btnViewSP.TabIndex = 7;
            this.btnViewSP.Text = " View";
            this.btnViewSP.UseCustomBackColor = true;
            this.btnViewSP.UseCustomForeColor = true;
            this.btnViewSP.UseSelectable = true;
            this.btnViewSP.UseStyleColors = true;
            this.btnViewSP.Click += new System.EventHandler(this.btnViewSP_Click);
            // 
            // btnDelSP
            // 
            this.btnDelSP.BackColor = System.Drawing.Color.Orange;
            this.btnDelSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelSP.BackgroundImage")));
            this.btnDelSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelSP.ForeColor = System.Drawing.Color.Black;
            this.btnDelSP.Location = new System.Drawing.Point(138, 13);
            this.btnDelSP.Name = "btnDelSP";
            this.btnDelSP.Size = new System.Drawing.Size(103, 30);
            this.btnDelSP.TabIndex = 8;
            this.btnDelSP.Text = " Delete";
            this.btnDelSP.UseCustomBackColor = true;
            this.btnDelSP.UseCustomForeColor = true;
            this.btnDelSP.UseSelectable = true;
            this.btnDelSP.UseStyleColors = true;
            this.btnDelSP.Click += new System.EventHandler(this.btnDelSP_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(30, 73);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(265, 20);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Выберите таблицу для редактирования";
            // 
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(909, 533);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAP";
            this.Resizable = false;
            this.Text = "MainAP";
            this.Load += new System.EventHandler(this.MainAP_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchPatternGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTSearchPattern)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid SearchPatternGrid;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnSaveSP;
        private MetroFramework.Controls.MetroComboBox cmbAction;
        private MetroFramework.Controls.MetroComboBox cmbCompare;
        private MetroFramework.Controls.MetroTextBox txtRegExp;
        private SearchBaseDataSetTSearchPattern searchBaseDataSetTSearchPattern;
        private System.Windows.Forms.BindingSource tSearchPatternBindingSource;
        private SearchBaseDataSetTSearchPatternTableAdapters.TSearchPatternTableAdapter tSearchPatternTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regularExpressionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compareWithDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnDelSP;
        private MetroFramework.Controls.MetroButton btnViewSP;
        private MetroFramework.Controls.MetroButton btnUpdSP;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}