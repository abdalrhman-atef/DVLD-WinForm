using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Users
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllUsers;
        private void _RefreshUsersList() 
        {
            _dtAllUsers = clsUsers.UsersList();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count>0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }
          
        }
        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text=="Is Active")
            {
                cbFilterIsActive.Visible = true;
                txbFilterValue.Visible = false;
                cbFilterIsActive.Focus();
                cbFilterIsActive.SelectedIndex = 0;

            }
            else
            {
                txbFilterValue.Visible = (cbFilterBy.Text != "None");
                cbFilterIsActive.Visible = false;
                txbFilterValue.Text = "";
                txbFilterValue.Focus();
            }
        }
        private void txbFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch(cbFilterBy.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;



            }

            if (FilterColumn== "None" || txbFilterValue.Text.Trim()=="")
            {
                _dtAllUsers.DefaultView.RowFilter = "";     
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }
           
            if (FilterColumn != "PersonID"&& FilterColumn != "UserID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txbFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txbFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }
        private void cbFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbFilterIsActive.Text;
            switch (cbFilterIsActive.Text) 
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";    
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }

            if (FilterValue=="All")
            {
                _dtAllUsers.DefaultView.RowFilter = "";

            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            }

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();



        }

        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frmAddUser = new frmAddUpdateUsers();
            frmAddUser.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUsers.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Person Deleted Successfuly", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();

                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers updateUser = new frmAddUpdateUsers((int)dgvUsers.CurrentRow.Cells[0].Value);
            updateUser.ShowDialog();
            _RefreshUsersList();
        }

        private void showInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo userInfo = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            userInfo.ShowDialog();
            _RefreshUsersList();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword password = new frmChangeUserPassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            password.ShowDialog();
            _RefreshUsersList();
        }
    }
}
