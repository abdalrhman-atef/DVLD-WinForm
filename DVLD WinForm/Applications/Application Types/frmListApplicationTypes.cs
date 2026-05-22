using DVLD_BusinessLayer;
using DVLD_WinForm.Applications.Application_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Applications
{
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

       
        private void _Reset() 
        {
            DataTable _AllTypes = clsApplicationTypes.ListApplicationTypes();

            dgvManageAppTypes.DataSource = _AllTypes;
            lblRecordsCount.Text = dgvManageAppTypes.Rows.Count.ToString();
            if (dgvManageAppTypes.Rows.Count>0)
            {
                dgvManageAppTypes.Columns[0].HeaderText = "ID";
                dgvManageAppTypes.Columns[0].Width = 110;

                dgvManageAppTypes.Columns[1].HeaderText = "Title";
                dgvManageAppTypes.Columns[1].Width = 400;

                dgvManageAppTypes.Columns[2].HeaderText = "Fees";
                dgvManageAppTypes.Columns[2].Width = 100;


            }

        }
        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {

            _Reset();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationTypes frm = new frmUpdateApplicationTypes((int)dgvManageAppTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmApplicationTypes_Load(null, null);
        }
    }
}
