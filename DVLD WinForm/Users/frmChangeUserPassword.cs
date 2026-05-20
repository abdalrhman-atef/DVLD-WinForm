using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Users
{
    public partial class frmChangeUserPassword : Form
    {
        private int _UserID;
        private clsUsers _User;
        public frmChangeUserPassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void ResetDefaultValues() 
        {
            txbCurrentPassword.Text = "";
            txbNewPassword.Text = "";
            txbPasswordConfirm.Text = "";
           

        }
        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            ResetDefaultValues();
            _User=clsUsers.FindByUserID(_UserID);
            if (_User!=null)
            {
                ctrlUserCard1.LoadUserInfo(_UserID);

            }
            else
            {
                MessageBox.Show("Could not Find User with id = " + _UserID,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

        }

        private void txbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbCurrentPassword, "Current Password Can not Be Blank");
                return;

            }
            else
            {
                errorProvider1.SetError(txbCurrentPassword, null);
            }
            if (_User._Password!= txbCurrentPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txbCurrentPassword, "Current Password Is Wrong");
                return;
            }
            else
            {
                errorProvider1.SetError(txbCurrentPassword, null);
            }
        }

        private void txbNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNewPassword, "Current Password Can not Be Blank");
                return;

            }
            else
            {
                errorProvider1.SetError(txbNewPassword, null);
            }
        }

        private void txbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txbPasswordConfirm.Text!=txbNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txbPasswordConfirm, "Password Confirmation does not match New Password!");
                return;

            }
            else
            {
                errorProvider1.SetError(txbPasswordConfirm, null);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not veiled!, put the mouse over the red icon(s) to see the error",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User._Password =txbNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                 "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
