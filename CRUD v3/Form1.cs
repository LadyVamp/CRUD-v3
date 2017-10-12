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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetTFileWithoutID.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter.Fill(this.searchBaseDataSetTFileWithoutID.TFile);
        }

        //  Поиск по названию
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    row.Selected = false;
                    this.tFileBindingSource.Filter = "(name LIKE '" + txtSearch.Text + "*')";
                }
            }

            catch
            {
                MessageBox.Show("Такого названия нет");
            }
        }

        //Заполнить grid таблицей TFile, кнопка "Все файлы"
        private void btnAllFiles_Click(object sender, EventArgs e)
        {
            string connect = "Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";
            DataSet ds = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile", dataBaseConnection);
            dataAdapter.Fill(ds, "TFile");
            metroGrid1.DataSource = ds.Tables["TFile"];
        }

    }
    }
