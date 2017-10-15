using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_v3
{
    public partial class MainAP : MetroFramework.Forms.MetroForm
    {
        public MainAP()
        {
            InitializeComponent();
            SPGrid.ColumnCount = 4;
            SPGrid.Columns[0].Name = "ID";
            SPGrid.Columns[1].Name = "regularExpression";
            SPGrid.Columns[2].Name = "compareWith";
            SPGrid.Columns[3].Name = "action";
            SPGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SPGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SPGrid.MultiSelect = false;
        }

        private void MainAP_Load(object sender, EventArgs e)
        {
            ViewSP();

            //заполнить dataGridView при запуске формы
            DataSet ds = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(CONNECTION_STRING);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile", dataBaseConnection);
            dataAdapter.Fill(ds, "TFile");
            FileGrid.DataSource = ds.Tables["TFile"];
            FileGrid.Columns[0].HeaderText = "ID";
            FileGrid.Columns[1].HeaderText = "Название";
            FileGrid.Columns[2].HeaderText = "Ключевые слова";
            FileGrid.Columns[3].HeaderText = "Размер, КБ";
            FileGrid.Columns[4].HeaderText = "Формат";
            FileGrid.Columns[5].HeaderText = "Содержание";
            FileGrid.Columns[6].HeaderText = "IdCatalog";
            FileGrid.Columns[0].Width = 30;
            FileGrid.Columns[1].Width = 80;
            FileGrid.Columns[2].Width = 80;
            FileGrid.Columns[3].Width = 60;
            FileGrid.Columns[4].Width = 60;
            FileGrid.Columns[5].Width = 100;
        }

        private const string CONNECTION_STRING =
  "Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";

        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        // --- CRUD for SearchPattern ---
        //  Create
        private void InsertSP(string regularExpression, string compareWith, string action)
        {
            string sql = "INSERT INTO TSearchPattern(regularExpression,compareWith,action) VALUES(@regularExpression,@compareWith,@action)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@regularExpression", regularExpression);
            cmd.Parameters.AddWithValue("@compareWith", compareWith);
            cmd.Parameters.AddWithValue("@action", action);
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Запись добавлена");
                }
                con.Close();
                ViewSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void populate(String id, String regularExpression, string compareWith, string action)
        {
            SPGrid.Rows.Add(id, regularExpression, compareWith, action);
        }

        //  Read  
        private void ViewSP()
        {
            SPGrid.Rows.Clear();
            string sql = "SELECT * FROM TSearchPattern";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //  Update
        private void UpdateSP(int id, string regularExpression, string compareWith, string action)
        {
            string sql = "UPDATE TSearchPattern SET regularExpression='" + regularExpression + "',compareWith='" + compareWith + "',action='" + action + "' WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Запись обновлена");
                }
                con.Close();
                ViewSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //  Delete
        private void DeleteSP(int id)
        {
            string sql = "DELETE FROM TSearchPattern WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                MessageBox.Show(con.State.ToString());
                adapter = new SqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                if (MessageBox.Show("Вы уверены?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        clearTxts();
                        MessageBox.Show("Запись удалена");
                    }
                }
                con.Close();
                ViewSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void clearTxts()
        {
            txtRegExp.Text = "";
            cmbCompare.Text = "";
            cmbAction.Text = "";
        }

        //private void SPGrid_MouseClick(object sender, MouseEventArgs e)
        //{
        //    txtRegExp.Text = SPGrid.SelectedRows[0].Cells[1].Value.ToString();
        //    cmbCompare.Text = SPGrid.SelectedRows[0].Cells[2].Value.ToString();
        //    cmbAction.Text = SPGrid.SelectedRows[0].Cells[3].Value.ToString();
        //}

        private void btnInsertSP_Click(object sender, EventArgs e)
        {
            if (txtRegExp.Text == "" || cmbCompare.Text == "" || cmbAction.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertSP(txtRegExp.Text, cmbCompare.Text, cmbAction.Text);
            }
        }

        private void btnViewSP_Click(object sender, EventArgs e)
        {
            ViewSP();
        }
        private void btnUpdSP_Click(object sender, EventArgs e)
        {
            if (txtRegExp.Text == "" || cmbCompare.Text == "" || cmbAction.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = SPGrid.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateSP(id, txtRegExp.Text, cmbCompare.Text, cmbAction.Text);
            }

        }
        private void btnDelSP_Click(object sender, EventArgs e)
        {
            String selected = SPGrid.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            DeleteSP(id);
        }

        // --- end CRUD for SearchPattern ---

        //TODO: CRUD for File



        //private void SPGrid_SelectionChanged(object sender, EventArgs e)
        //{
        //    SPGrid.Rows[0].Cells["regularExpression"].Value = txtRegExp.Text;
        //    SPGrid.Rows[0].Cells["compareWith"].Value = cmbCompare.Text;
        //    SPGrid.Rows[0].Cells["action"].Value = cmbAction.Text;
        //}

        //private void SPGrid_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtRegExp.Text = SPGrid.Rows[0].Cells["regularExpression"].Value.ToString();
        //    cmbCompare.Text = SPGrid.Rows[0].Cells["compareWith"].Value.ToString();
        //    cmbAction.Text = SPGrid.Rows[0].Cells["action"].Value.ToString();
        //}

        //Заполнить текстбоксы/комбобоксы данными из dataGridView (не работает)
        //private void SPGrid_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    if (SPGrid.CurrentCell != null && SPGrid.CurrentCell.RowIndex >= 0)
        //    {
        //        txtRegExp.Text = SPGrid.Rows[SPGrid.CurrentCell.RowIndex].Cells["regularExpression"].Value.ToString();
        //        cmbCompare.Text = SPGrid.Rows[SPGrid.CurrentCell.RowIndex].Cells["compareWith"].Value.ToString();
        //        cmbAction.Text = SPGrid.Rows[SPGrid.CurrentCell.RowIndex].Cells["action"].Value.ToString();
        //    }
        //}

            //так тоже не работает
        //    private void FileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // get datagridview selected row 
        //   int selectedRow = e.RowIndex;
        //    DataGridViewRow row = SPGrid.Rows[selectedRow];

        //    // display datagridview selected row data into textboxes 
        //    txtRegExp.Text = row.Cells[0].Value.ToString();
        //    cmbCompare.Text = row.Cells[1].Value.ToString();
        //    cmbAction.Text = row.Cells[2].Value.ToString();
        //}



        //---   CRUD for TFile  ---
        //Create
        private void InsertFile(string name, string keywords, string size, string format, string content, string IdCatalog)
        {
            string sql = "INSERT INTO TFile(name,keywords,size, format, content, IdCatalog) VALUES(@name,@keywords,@size, @format, @content, @IdCatalog)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@keywords", keywords);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@format", format);
            cmd.Parameters.AddWithValue("@content", content);
            cmd.Parameters.AddWithValue("@IdCatalog", IdCatalog);
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxtsFile();
                    MessageBox.Show("Запись добавлена!");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void populate(String id, String name, string keywords, string size, string format, string content, string IdCatalog)
        {
            FileGrid.Rows.Add(id, name, keywords, size, format, content, IdCatalog);
        }

        private void retrieve()
        {
            FileGrid.Rows.Clear();
            string sql = "SELECT * FROM TFile";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //Update
        private void UpdateFile(int id, string name, string keywords, string size, string format, string content, string IdCatalog)
        {
            string sql = "UPDATE TFile SET name='" + name + "', keywords='" + keywords + "',size='" + size + "',format='" + format + "',content='" + content + "', IdCatalog='" + IdCatalog + "' WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxtsFile();
                    MessageBox.Show("Запись обновлена!");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void DeleteFile(int id)
        {
            string sql = "DELETE FROM TFile WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                MessageBox.Show(con.State.ToString());
                adapter = new SqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                if (MessageBox.Show("Вы уверены?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        clearTxtsFile();
                        MessageBox.Show("Запись удалена!");
                    }
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void clearTxtsFile()
        {
            txtFileName.Text = "";
            txtKeywords.Text = "";
            txtSize.Text = "";
            cmbFormat.Text = "";
            txtContent.Text = "";
            cmbCatalog.Text = "";
        }
        //private void FileGrid_MouseClick(object sender, MouseEventArgs e)
        //{
        //    txtFileName.Text = FileGrid.SelectedRows[0].Cells[1].Value.ToString();
        //    txtKeywords.Text = FileGrid.SelectedRows[0].Cells[2].Value.ToString();
        //    txtSize.Text = FileGrid.SelectedRows[0].Cells[3].Value.ToString();
        //    cmbFormat.Text = FileGrid.SelectedRows[0].Cells[4].Value.ToString();
        //    txtContent.Text = FileGrid.SelectedRows[0].Cells[5].Value.ToString();
        //    cmbCatalog.Text = FileGrid.SelectedRows[0].Cells[6].Value.ToString();
        //}


        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "" || txtKeywords.Text == "" || txtSize.Text == "" || cmbFormat.Text == "" || txtContent.Text == "" || cmbCatalog.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertFile(txtFileName.Text, txtKeywords.Text, txtSize.Text, cmbFormat.Text, txtContent.Text, cmbCatalog.Text);
            }

        }
        private void btnViewFile_Click(object sender, EventArgs e)
        {
            retrieve();
        }
        private void btnUpdFile_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "" || txtKeywords.Text == "" || txtSize.Text == "" || cmbFormat.Text == "" || txtContent.Text == "" || cmbCatalog.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = FileGrid.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateFile(id, txtFileName.Text, txtKeywords.Text, txtSize.Text, cmbFormat.Text, txtContent.Text, cmbCatalog.Text);
            }


        }
        private void btnDelFile_Click(object sender, EventArgs e)
        {
            String selected = FileGrid.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            DeleteFile(id);
        }

    }
}
