using DVLD_BusinessLayer;
using DVLD_WinForm.Tests.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Tests
{
    public partial class frmTestTypesList : Form
    {
      
        public frmTestTypesList()
        {
            InitializeComponent();
        }
        
        private void _Reset() 
        {
            DataTable _AllTestTypes = clsTestTypes.TestTypesList();
            dgvTestTypes.DataSource = _AllTestTypes;
           
            lblRecordsValue.Text = dgvTestTypes.Rows.Count.ToString();
            if (dgvTestTypes.Rows.Count>0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 120;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 200;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 400;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypesList_Load(object sender, EventArgs e)
        {
            _Reset();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frm = new frmUpdateTestTypes((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Reset();
        }
    }
}
