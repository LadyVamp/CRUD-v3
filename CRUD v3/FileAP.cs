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
//        private const string CONNECTION_STRING =
//"Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";

//        SqlConnection con = new SqlConnection(CONNECTION_STRING);
//        SqlCommand cmd;
//        SqlDataAdapter adapter;
//        DataTable dt = new DataTable();

        public FileAP()
        {
            InitializeComponent();
        }

        private async void mtAdd_Click(object sender, EventArgs e)
        {
            using(AddEditFile frm = new AddEditFile(new TFile() ))
            {
                //frm.ShowDialog();
                if (frm.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        tFileBindingSource.Add(frm.FileInfo);
                        db.TFile.Add(frm.FileInfo);
                        await db.SaveChangesAsync();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
        private void mtRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tFileBindingSource.DataSource = db.TFile.ToList();
            tCatalogBindingSource.DataSource = db.TCatalog.ToList();
            Cursor.Current = Cursors.Default;
        }

        SearchBaseEntities db;

        private void FileAP_Load(object sender, EventArgs e)
        {
            db = new SearchBaseEntities();
            tFileBindingSource.DataSource = db.TFile.ToList();
            tCatalogBindingSource.DataSource = db.TCatalog.ToList();
        }

        private async void mtEdit_Click(object sender, EventArgs e)
        {
            TFile obj = tFileBindingSource.Current as TFile;
            if (obj != null)
            {
                using(AddEditFile frm  = new AddEditFile(obj))
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tFileBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = FileGrid.RowCount;
                for (int i = rows-1; i>=0; i--)
                {
                    if(FileGrid.Rows[i].Selected)
                    {
                        db.TFile.Remove(FileGrid.Rows[i].DataBoundItem as TFile);
                        tFileBindingSource.RemoveAt(FileGrid.Rows[i].Index);
                    }
                }
            }
        }

        private async void mtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Вы хотите сохранить изменения?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    tFileBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }
    }
}
