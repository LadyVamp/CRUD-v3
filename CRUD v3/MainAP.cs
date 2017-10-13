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
            string sql = "SELECT * FROM TSearchPattern ";
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

        private void SPGrid_MouseClick(object sender, MouseEventArgs e)
        {
            txtRegExp.Text = SPGrid.SelectedRows[0].Cells[1].Value.ToString();
            cmbCompare.Text = SPGrid.SelectedRows[0].Cells[2].Value.ToString();
            cmbAction.Text = SPGrid.SelectedRows[0].Cells[3].Value.ToString();
        }

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
        private void clearBtn_Click(object sender, EventArgs e)
        {
            SPGrid.Rows.Clear();
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


        // --- CRUD for File ---
        //Размер только цифрами
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




    }
}
