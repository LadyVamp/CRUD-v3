﻿namespace CRUD_v3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.SPGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnDelSP = new MetroFramework.Controls.MetroButton();
            this.btnViewSP = new MetroFramework.Controls.MetroButton();
            this.btnUpdSP = new MetroFramework.Controls.MetroButton();
            this.btnSaveSP = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbAction = new MetroFramework.Controls.MetroComboBox();
            this.cmbCompare = new MetroFramework.Controls.MetroComboBox();
            this.txtRegExp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.GridFile = new MetroFramework.Controls.MetroGrid();
            this.cmbFormat = new MetroFramework.Controls.MetroComboBox();
            this.txtKeywords = new MetroFramework.Controls.MetroTextBox();
            this.txtFileName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tSearchPatternBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSetTSearchPattern = new CRUD_v3.SearchBaseDataSetTSearchPattern();
            this.tSearchPatternTableAdapter = new CRUD_v3.SearchBaseDataSetTSearchPatternTableAdapters.TSearchPatternTableAdapter();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnDelF = new MetroFramework.Controls.MetroButton();
            this.btnViewF = new MetroFramework.Controls.MetroButton();
            this.btnUpdF = new MetroFramework.Controls.MetroButton();
            this.btnSaveF = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGrid)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTSearchPattern)).BeginInit();
            this.metroPanel3.SuspendLayout();
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
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(857, 413);
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
            this.metroTabPage1.Controls.Add(this.SPGrid);
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(849, 371);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Шаблоны поиска";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // SPGrid
            // 
            this.SPGrid.AllowUserToResizeRows = false;
            this.SPGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SPGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SPGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SPGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SPGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SPGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SPGrid.EnableHeadersVisualStyles = false;
            this.SPGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SPGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SPGrid.Location = new System.Drawing.Point(0, 148);
            this.SPGrid.Name = "SPGrid";
            this.SPGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SPGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SPGrid.RowTemplate.Height = 24;
            this.SPGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPGrid.Size = new System.Drawing.Size(662, 216);
            this.SPGrid.Style = MetroFramework.MetroColorStyle.Blue;
            this.SPGrid.TabIndex = 4;
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
            this.metroPanel2.Location = new System.Drawing.Point(401, 12);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(261, 122);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnDelSP
            // 
            this.btnDelSP.BackColor = System.Drawing.Color.Orange;
            this.btnDelSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelSP.BackgroundImage")));
            this.btnDelSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelSP.ForeColor = System.Drawing.Color.Black;
            this.btnDelSP.Location = new System.Drawing.Point(149, 5);
            this.btnDelSP.Name = "btnDelSP";
            this.btnDelSP.Size = new System.Drawing.Size(103, 30);
            this.btnDelSP.TabIndex = 8;
            this.btnDelSP.Text = "  Delete";
            this.btnDelSP.UseCustomBackColor = true;
            this.btnDelSP.UseCustomForeColor = true;
            this.btnDelSP.UseSelectable = true;
            this.btnDelSP.UseStyleColors = true;
            this.btnDelSP.Click += new System.EventHandler(this.btnDelSP_Click);
            // 
            // btnViewSP
            // 
            this.btnViewSP.BackColor = System.Drawing.Color.Orange;
            this.btnViewSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewSP.BackgroundImage")));
            this.btnViewSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewSP.ForeColor = System.Drawing.Color.Black;
            this.btnViewSP.Location = new System.Drawing.Point(15, 82);
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
            // btnUpdSP
            // 
            this.btnUpdSP.BackColor = System.Drawing.Color.Orange;
            this.btnUpdSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdSP.BackgroundImage")));
            this.btnUpdSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdSP.ForeColor = System.Drawing.Color.Black;
            this.btnUpdSP.Location = new System.Drawing.Point(15, 42);
            this.btnUpdSP.Name = "btnUpdSP";
            this.btnUpdSP.Size = new System.Drawing.Size(103, 30);
            this.btnUpdSP.TabIndex = 6;
            this.btnUpdSP.Text = "  Update";
            this.btnUpdSP.UseCustomBackColor = true;
            this.btnUpdSP.UseCustomForeColor = true;
            this.btnUpdSP.UseSelectable = true;
            this.btnUpdSP.UseStyleColors = true;
            this.btnUpdSP.Click += new System.EventHandler(this.btnUpdSP_Click);
            // 
            // btnSaveSP
            // 
            this.btnSaveSP.BackColor = System.Drawing.Color.Orange;
            this.btnSaveSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSP.BackgroundImage")));
            this.btnSaveSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveSP.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSP.Location = new System.Drawing.Point(15, 5);
            this.btnSaveSP.Name = "btnSaveSP";
            this.btnSaveSP.Size = new System.Drawing.Size(103, 30);
            this.btnSaveSP.TabIndex = 2;
            this.btnSaveSP.Text = " Insert";
            this.btnSaveSP.UseCustomBackColor = true;
            this.btnSaveSP.UseCustomForeColor = true;
            this.btnSaveSP.UseSelectable = true;
            this.btnSaveSP.UseStyleColors = true;
            this.btnSaveSP.Click += new System.EventHandler(this.btnInsertSP_Click);
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
            this.metroPanel1.Location = new System.Drawing.Point(0, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(385, 122);
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
            this.cmbAction.Location = new System.Drawing.Point(209, 82);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(160, 30);
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
            this.cmbCompare.Location = new System.Drawing.Point(209, 42);
            this.cmbCompare.Name = "cmbCompare";
            this.cmbCompare.Size = new System.Drawing.Size(160, 30);
            this.cmbCompare.TabIndex = 7;
            this.cmbCompare.UseSelectable = true;
            // 
            // txtRegExp
            // 
            // 
            // 
            // 
            this.txtRegExp.CustomButton.Image = null;
            this.txtRegExp.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtRegExp.CustomButton.Name = "";
            this.txtRegExp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRegExp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegExp.CustomButton.TabIndex = 1;
            this.txtRegExp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRegExp.CustomButton.UseSelectable = true;
            this.txtRegExp.CustomButton.Visible = false;
            this.txtRegExp.DisplayIcon = true;
            this.txtRegExp.Lines = new string[0];
            this.txtRegExp.Location = new System.Drawing.Point(209, 9);
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
            this.txtRegExp.Size = new System.Drawing.Size(160, 26);
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
            this.metroLabel4.Location = new System.Drawing.Point(3, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Действие";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 52);
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
            this.metroLabel2.Size = new System.Drawing.Size(161, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Регулярное выражение";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.MintCream;
            this.metroTabPage2.Controls.Add(this.metroPanel3);
            this.metroTabPage2.Controls.Add(this.txtContent);
            this.metroTabPage2.Controls.Add(this.txtSize);
            this.metroTabPage2.Controls.Add(this.GridFile);
            this.metroTabPage2.Controls.Add(this.cmbFormat);
            this.metroTabPage2.Controls.Add(this.txtKeywords);
            this.metroTabPage2.Controls.Add(this.txtFileName);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(849, 371);
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
            // GridFile
            // 
            this.GridFile.AllowUserToResizeRows = false;
            this.GridFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFile.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFile.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridFile.EnableHeadersVisualStyles = false;
            this.GridFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridFile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFile.Location = new System.Drawing.Point(334, 26);
            this.GridFile.Name = "GridFile";
            this.GridFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridFile.RowTemplate.Height = 24;
            this.GridFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFile.Size = new System.Drawing.Size(519, 338);
            this.GridFile.Style = MetroFramework.MetroColorStyle.Teal;
            this.GridFile.TabIndex = 11;
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
            this.cmbFormat.Location = new System.Drawing.Point(142, 129);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(160, 30);
            this.cmbFormat.TabIndex = 8;
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
            this.txtKeywords.Location = new System.Drawing.Point(142, 60);
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
            this.txtKeywords.TabIndex = 8;
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
            this.txtFileName.Location = new System.Drawing.Point(142, 26);
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
            this.txtFileName.TabIndex = 7;
            this.txtFileName.UseCustomBackColor = true;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.UseStyleColors = true;
            this.txtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(0, 168);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(94, 20);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "Cодержимое";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(1, 135);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 20);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Формат";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1, 95);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 20);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Размер";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(1, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 20);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Ключевые слова";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 20);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Название";
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
            // tSearchPatternTableAdapter
            // 
            this.tSearchPatternTableAdapter.ClearBeforeFill = true;
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
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(142, 101);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 12;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(142, 168);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(160, 54);
            this.txtContent.TabIndex = 13;
            this.txtContent.Text = "";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.btnDelF);
            this.metroPanel3.Controls.Add(this.btnViewF);
            this.metroPanel3.Controls.Add(this.btnUpdF);
            this.metroPanel3.Controls.Add(this.btnSaveF);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 242);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(302, 122);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnDelF
            // 
            this.btnDelF.BackColor = System.Drawing.Color.Teal;
            this.btnDelF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelF.BackgroundImage")));
            this.btnDelF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelF.ForeColor = System.Drawing.Color.White;
            this.btnDelF.Location = new System.Drawing.Point(149, 5);
            this.btnDelF.Name = "btnDelF";
            this.btnDelF.Size = new System.Drawing.Size(103, 30);
            this.btnDelF.TabIndex = 8;
            this.btnDelF.Text = "  Delete";
            this.btnDelF.UseCustomBackColor = true;
            this.btnDelF.UseCustomForeColor = true;
            this.btnDelF.UseSelectable = true;
            this.btnDelF.UseStyleColors = true;
            // 
            // btnViewF
            // 
            this.btnViewF.BackColor = System.Drawing.Color.Teal;
            this.btnViewF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewF.BackgroundImage")));
            this.btnViewF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewF.ForeColor = System.Drawing.Color.White;
            this.btnViewF.Location = new System.Drawing.Point(15, 82);
            this.btnViewF.Name = "btnViewF";
            this.btnViewF.Size = new System.Drawing.Size(103, 30);
            this.btnViewF.TabIndex = 7;
            this.btnViewF.Text = " View";
            this.btnViewF.UseCustomBackColor = true;
            this.btnViewF.UseCustomForeColor = true;
            this.btnViewF.UseSelectable = true;
            this.btnViewF.UseStyleColors = true;
            // 
            // btnUpdF
            // 
            this.btnUpdF.BackColor = System.Drawing.Color.Teal;
            this.btnUpdF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdF.BackgroundImage")));
            this.btnUpdF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdF.ForeColor = System.Drawing.Color.White;
            this.btnUpdF.Location = new System.Drawing.Point(15, 41);
            this.btnUpdF.Name = "btnUpdF";
            this.btnUpdF.Size = new System.Drawing.Size(103, 30);
            this.btnUpdF.TabIndex = 6;
            this.btnUpdF.Text = "  Update";
            this.btnUpdF.UseCustomBackColor = true;
            this.btnUpdF.UseCustomForeColor = true;
            this.btnUpdF.UseSelectable = true;
            this.btnUpdF.UseStyleColors = true;
            // 
            // btnSaveF
            // 
            this.btnSaveF.BackColor = System.Drawing.Color.Teal;
            this.btnSaveF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveF.BackgroundImage")));
            this.btnSaveF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveF.ForeColor = System.Drawing.Color.White;
            this.btnSaveF.Location = new System.Drawing.Point(15, 5);
            this.btnSaveF.Name = "btnSaveF";
            this.btnSaveF.Size = new System.Drawing.Size(103, 30);
            this.btnSaveF.TabIndex = 2;
            this.btnSaveF.Text = " Insert";
            this.btnSaveF.UseCustomBackColor = true;
            this.btnSaveF.UseCustomForeColor = true;
            this.btnSaveF.UseSelectable = true;
            this.btnSaveF.UseStyleColors = true;
            // 
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(910, 561);
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
            ((System.ComponentModel.ISupportInitialize)(this.SPGrid)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTSearchPattern)).EndInit();
            this.metroPanel3.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroGrid SPGrid;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnSaveSP;
        private MetroFramework.Controls.MetroComboBox cmbAction;
        private MetroFramework.Controls.MetroComboBox cmbCompare;
        private MetroFramework.Controls.MetroTextBox txtRegExp;
        private SearchBaseDataSetTSearchPattern searchBaseDataSetTSearchPattern;
        private System.Windows.Forms.BindingSource tSearchPatternBindingSource;
        private SearchBaseDataSetTSearchPatternTableAdapters.TSearchPatternTableAdapter tSearchPatternTableAdapter;
        private MetroFramework.Controls.MetroButton btnDelSP;
        private MetroFramework.Controls.MetroButton btnViewSP;
        private MetroFramework.Controls.MetroButton btnUpdSP;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbFormat;
        private MetroFramework.Controls.MetroTextBox txtKeywords;
        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroGrid GridFile;
        private System.Windows.Forms.TextBox txtSize;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnDelF;
        private MetroFramework.Controls.MetroButton btnViewF;
        private MetroFramework.Controls.MetroButton btnUpdF;
        private MetroFramework.Controls.MetroButton btnSaveF;
        private System.Windows.Forms.RichTextBox txtContent;
    }
}