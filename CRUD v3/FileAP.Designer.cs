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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileAP));
            this.searchBaseDataSetTFile = new CRUD_v3.SearchBaseDataSetTFile();
            this.searchBaseDataSetTFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.FileGrid = new System.Windows.Forms.DataGridView();
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.tCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCatalogDataGridViewCombobox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBaseDataSetTFile
            // 
            this.searchBaseDataSetTFile.DataSetName = "SearchBaseDataSetTFile";
            this.searchBaseDataSetTFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchBaseDataSetTFileBindingSource
            // 
            this.searchBaseDataSetTFileBindingSource.DataSource = this.searchBaseDataSetTFile;
            this.searchBaseDataSetTFileBindingSource.Position = 0;
            // 
            // mtRefresh
            // 
            this.mtRefresh.ActiveControl = null;
            this.mtRefresh.BackColor = System.Drawing.Color.Teal;
            this.mtRefresh.Location = new System.Drawing.Point(23, 63);
            this.mtRefresh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.Size = new System.Drawing.Size(75, 67);
            this.mtRefresh.TabIndex = 0;
            this.mtRefresh.Text = "Refresh";
            this.mtRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRefresh.TileImage")));
            this.mtRefresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRefresh.UseCustomBackColor = true;
            this.mtRefresh.UseSelectable = true;
            this.mtRefresh.UseStyleColors = true;
            this.mtRefresh.UseTileImage = true;
            this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.BackColor = System.Drawing.Color.Teal;
            this.mtAdd.Location = new System.Drawing.Point(104, 63);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(75, 67);
            this.mtAdd.TabIndex = 1;
            this.mtAdd.Text = "Add";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAdd.TileImage")));
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.UseCustomBackColor = true;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.UseStyleColors = true;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.ActiveControl = null;
            this.mtEdit.BackColor = System.Drawing.Color.Teal;
            this.mtEdit.Location = new System.Drawing.Point(185, 63);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(75, 67);
            this.mtEdit.TabIndex = 3;
            this.mtEdit.Text = "Edit";
            this.mtEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEdit.TileImage")));
            this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEdit.UseCustomBackColor = true;
            this.mtEdit.UseSelectable = true;
            this.mtEdit.UseStyleColors = true;
            this.mtEdit.UseTileImage = true;
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.ActiveControl = null;
            this.mtDelete.BackColor = System.Drawing.Color.Teal;
            this.mtDelete.Location = new System.Drawing.Point(266, 63);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(75, 67);
            this.mtDelete.TabIndex = 4;
            this.mtDelete.Text = "Delete";
            this.mtDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDelete.TileImage")));
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.UseCustomBackColor = true;
            this.mtDelete.UseSelectable = true;
            this.mtDelete.UseStyleColors = true;
            this.mtDelete.UseTileImage = true;
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // FileGrid
            // 
            this.FileGrid.AutoGenerateColumns = false;
            this.FileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.idCatalogDataGridViewCombobox});
            this.FileGrid.DataSource = this.tFileBindingSource;
            this.FileGrid.Location = new System.Drawing.Point(23, 147);
            this.FileGrid.Name = "FileGrid";
            this.FileGrid.RowTemplate.Height = 24;
            this.FileGrid.Size = new System.Drawing.Size(859, 331);
            this.FileGrid.TabIndex = 5;
            // 
            // tFileBindingSource
            // 
            this.tFileBindingSource.DataSource = typeof(CRUD_v3.TFile);
            // 
            // mtSave
            // 
            this.mtSave.ActiveControl = null;
            this.mtSave.BackColor = System.Drawing.Color.Teal;
            this.mtSave.Location = new System.Drawing.Point(347, 63);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(75, 67);
            this.mtSave.TabIndex = 6;
            this.mtSave.Text = "Save";
            this.mtSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSave.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSave.TileImage")));
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.UseCustomBackColor = true;
            this.mtSave.UseSelectable = true;
            this.mtSave.UseStyleColors = true;
            this.mtSave.UseTileImage = true;
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // tCatalogBindingSource
            // 
            this.tCatalogBindingSource.DataSource = typeof(CRUD_v3.TCatalog);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
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
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // idCatalogDataGridViewCombobox
            // 
            this.idCatalogDataGridViewCombobox.DataPropertyName = "IdCatalog";
            this.idCatalogDataGridViewCombobox.DataSource = this.tCatalogBindingSource;
            this.idCatalogDataGridViewCombobox.DisplayMember = "Title";
            this.idCatalogDataGridViewCombobox.HeaderText = "Catalog";
            this.idCatalogDataGridViewCombobox.Name = "idCatalogDataGridViewCombobox";
            this.idCatalogDataGridViewCombobox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCatalogDataGridViewCombobox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCatalogDataGridViewCombobox.ValueMember = "Id";
            // 
            // FileAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 501);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.FileGrid);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.mtRefresh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileAP";
            this.Resizable = false;
            this.Text = "FileAP";
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetTFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource searchBaseDataSetTFileBindingSource;
        private SearchBaseDataSetTFile searchBaseDataSetTFile;
        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private System.Windows.Forms.DataGridView FileGrid;
        private MetroFramework.Controls.MetroTile mtSave;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCatalogDataGridViewCombobox;
        private System.Windows.Forms.BindingSource tCatalogBindingSource;
    }
}