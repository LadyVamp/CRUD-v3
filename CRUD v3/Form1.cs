﻿using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseTFileNewWithoutID.TFileNew". При необходимости она может быть перемещена или удалена.
            this.tFileNewTableAdapter.Fill(this.searchBaseTFileNewWithoutID.TFileNew);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetTFileWithoutID.TFile". При необходимости она может быть перемещена или удалена.
            ////this.tFileTableAdapter.Fill(this.searchBaseDataSetTFileWithoutID.TFile);
            metroGrid1.Columns[0].Width = 280;
            metroGrid1.Columns[1].Width = 60;
            metroGrid1.Columns[2].Width = 50;
            metroGrid1.Columns[3].Width = 50;
            metroGrid1.Columns[4].Width = 50;
            metroGrid1.Columns[5].Width = 20;

        }

        //  Поиск по названию
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //tFileNewBindingSource.Filter = null;
            tFileNewBindingSource.Filter = null;
            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    row.Selected = false;
                    this.tFileNewBindingSource.Filter = "(name LIKE '" + txtSearch.Text + "*')";
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
            //tFileNewBindingSource.Filter = null;
            tFileNewBindingSource.Filter = null;
            //this.tFileNewBindingSource.Filter = "(format LIKE 'doc')";
            this.tFileNewBindingSource.Filter = "(format LIKE 'doc')";
        }

        private void rbDocx_CheckedChanged(object sender, EventArgs e)
        {
            //tFileNewBindingSource.Filter = null;
            tFileNewBindingSource.Filter = null;
            this.tFileNewBindingSource.Filter = "(format LIKE 'docx')";
        }

        private void rbTxt_CheckedChanged(object sender, EventArgs e)
        {
            //tFileNewBindingSource.Filter = null;
            tFileNewBindingSource.Filter = null;
            this.tFileNewBindingSource.Filter = "(format LIKE 'txt')";
        }

        private void rbRtf_CheckedChanged(object sender, EventArgs e)
        {
            //tFileNewBindingSource.Filter = null;
            tFileNewBindingSource.Filter = null;
            this.tFileNewBindingSource.Filter = "(format LIKE 'rtf')";
        }

        private void btnCallFormLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
        }

        //Вводить в textbox только цифры
        private void txtMinSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txtMaxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        //Фильтр по размеру файла
        private void btnSizeFilter_Click(object sender, EventArgs e)
        {
            tFileNewBindingSource.Filter = null;
            try
            {
                if (txtMinSize.Text != "" && txtMaxSize.Text != "") //оба заполнены
                {
                    tFileNewBindingSource.Filter = null;
                    this.tFileNewBindingSource.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
                    this.tFileNewBindingSource.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
                }
                else if (txtMinSize.Text == "" && txtMaxSize.Text == "") //оба пустые 
                {
                    MessageBox.Show("Поля min и max размер не заполнены");
                }
                else if (txtMinSize.Text != "" && txtMaxSize.Text == "") //заполнен только min
                {
                    tFileNewBindingSource.Filter = null;
                    this.tFileNewBindingSource.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
                }
                else if (txtMaxSize.Text != "" && txtMinSize.Text == "") //заполнен только max
                {
                    tFileNewBindingSource.Filter = null;
                    this.tFileNewBindingSource.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //TODO: сделать, чтобы фильтр по размеру учитывал фильтрацию по формату



    }
    }
