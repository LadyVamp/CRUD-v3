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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
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
            tFileBindingSource.Filter = null;
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

        //Радиокнопки по формату
        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(format LIKE 'doc')";
        }

        private void rbDocx_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(format LIKE 'docx')";
        }

        private void rbTxt_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(format LIKE 'txt')";
        }

        private void rbRtf_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(format LIKE 'rtf')";
        }

        private void btnCallFormLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
        }



        private void btnSizeFilter_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            //this.tFileBindingSource.Filter = "(size > 'txtMinSize.Text' and size< 'txtMaxSize.Text')";
            //txtMinSize.Text = null;
            //txtMaxSize.Text = null;

            //this.tFileBindingSource.Filter = "size >= '" + txtMinSize.Text + "'";
            //this.tFileBindingSource.Filter = "size <= '" + txtMaxSize.Text + "'";

            //this.tFileBindingSource.Filter = "(size > 0 and size< 20)";

            try
            {
               

                if (txtMinSize.Text != "" && txtMinSize.Text != "") //оба заполнены
                {
                    this.tFileBindingSource.Filter = "size >= '" + txtMinSize.Text + "'";
                    this.tFileBindingSource.Filter = "size <= '" + txtMaxSize.Text + "'";
                }
                else if (txtMinSize.Text == "" && txtMinSize.Text == "") //оба пустые 
                {
                    MessageBox.Show("Поля min и max размер не заполнены");
                }
                else if (txtMinSize.Text != "" && txtMaxSize.Text == "") //заполнен только min
                {
                    this.tFileBindingSource.Filter = "size >= '" + txtMinSize.Text + "'";
                }
                else if (txtMaxSize.Text != "" && txtMinSize.Text == "") //заполнен только max
                {
                    this.tFileBindingSource.Filter = "size <= '" + txtMaxSize.Text + "'";
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show("Минимальный и максимальный размер не заполнены!!!!!!!!!!!!");
                MessageBox.Show(ex.Message);
            }


        }



    }
    }
