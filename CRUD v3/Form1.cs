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

        

    }
    }
