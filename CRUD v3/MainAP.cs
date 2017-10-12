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
        }

        private void MainAP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetTSearchPattern.TSearchPattern". При необходимости она может быть перемещена или удалена.
            this.tSearchPatternTableAdapter.Fill(this.searchBaseDataSetTSearchPattern.TSearchPattern);

        }

        private const string CONNECTION_STRING =
  "Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";

        SqlConnection con = new SqlConnection(CONNECTION_STRING);

        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES ('" + txtRegExp.Text + "','" + cmbCompare.Text + "','" + cmbAction.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Запись добавлена");
        }

        private void btnUpdSP_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE TSearchPattern SET regularExpression ='" + txtRegExp.Text + "', compareWith='" + cmbCompare.Text + "', action='" + cmbAction.Text + "' WHERE regularExpression=" + txtRegExp.Text;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            con.Close();
            MessageBox.Show("Запись обновлена");
        }

        private void btnViewSP_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM TSearchPattern ORDER BY ID";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SearchPatternGrid.DataSource = dt;
            con.Close();
        }

        private void btnDelSP_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM TSearchPattern WHERE regularExpression='" + txtRegExp.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            con.Close();
            MessageBox.Show("Запись удалена");
        }
    }
}
