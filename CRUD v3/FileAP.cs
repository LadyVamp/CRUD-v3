


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
    public partial class FileAP : MetroFramework.Forms.MetroForm
    {
        private const string CONNECTION_STRING =
"Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";

        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FileAP()
        {
            InitializeComponent();
            //FileGrid.ColumnCount = 7;
            FileGrid.Columns[0].Name = "id";
            FileGrid.Columns[1].Name = "name";
            FileGrid.Columns[2].Name = "keywords";
            FileGrid.Columns[3].Name = "size";
            FileGrid.Columns[4].Name = "format";
            FileGrid.Columns[5].Name = "content";
            FileGrid.Columns[6].Name = "IdCatalog";
            FileGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FileGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FileGrid.MultiSelect = false;
        }

        private void FileAP_Load(object sender, EventArgs e)
        {
            retrieve();
        }

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

        private void FileAP_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetTFileForFileAP.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter.Fill(this.searchBaseDataSetTFileForFileAP.TFile);

        }

    }
}
