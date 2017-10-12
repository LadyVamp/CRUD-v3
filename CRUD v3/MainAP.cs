using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnAdminSP_Click(object sender, EventArgs e)
        {
            AdminSP f = new AdminSP();
            f.Show();
        }
    }
}
