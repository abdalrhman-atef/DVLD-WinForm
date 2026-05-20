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
    public partial class frmAddUpdateUsers : Form
    {
        public enum enMode {AddNew=0,Update=1};
        public enMode _Mode ;
        private int  _UserID=-1;
        clsUsers _User;



        public frmAddUpdateUsers()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;
        }
        public frmAddUpdateUsers(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID=UserID;
        }

        private void _ResetDefaultInfo() 
        {
            if (_Mode==enMode.AddNew)
            {
                lblAddUpdateUser.Text = "Add New User";
                this.Text= lblAddUpdateUser.Text;
                _User = new clsUsers();
                tcLoginInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblAddUpdateUser.Text = "Update User";
                this.Text = lblAddUpdateUser.Text;
                tcLoginInfo.Enabled = true;
                btnSave.Enabled = true;

            }
            txbUserName.Text = "";
            txbPassword.Text = "";
            txbPasswordConfirm.Text = "";
            chbIsActive.Checked = true;

        }

        private void _LoadData() 
        {
            _User= clsUsers.FindByUserID( _UserID );
            ctrlPersonCardWithFilter1.FilterEnabled = false;
          
            if (_User== null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;

            }
            lblUserIDValue.Text = _User._UserID.ToString();
            txbUserName.Text=_User._UserName;
            txbPassword.Text=_User._Password;
            txbPasswordConfirm.Text = _User._Password;
            chbIsActive.Checked= _User._IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User._PersonID);




        }
        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _ResetDefaultInfo();
            if (_Mode==enMode.Update)
            {
                _LoadData();
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // case : Update
            if (_Mode==enMode.Update)
            {
                btnSave.Enabled = true;
                tcLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab= tcUserInfo.TabPages["tcLoginInfo"];
                return;
            }

            // case :Add New 
            if (ctrlPersonCardWithFilter1.PersonID!=-1)
            {
                if (clsUsers.IsExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();

                }
                else
                {
                    btnSave.Enabled = true;
                    tcLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tcLoginInfo"];
                }

            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }


        }

        private void txbPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txbPasswordConfirm.Text.Trim() != txbPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txbPasswordConfirm, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txbPasswordConfirm, null);
            }
            ;
        }

        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txbPassword, null);
            }
            ;
        }

        private void txbUserName_Validating(object sender, CancelEventArgs e)
        {
            // case : Empty TextBox
            if (string.IsNullOrEmpty(txbUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError (txbUserName, null);
            };
             
            // Case Add New User 
            if (_Mode==enMode.AddNew)
            {
                if (clsUsers.IsExist(txbUserName.Text.Trim()))
                {
                    
                    e.Cancel=true;
                    errorProvider1.SetError(txbUserName, "User Name Is Used By Another User");
              
                }
                else
                {
                    errorProvider1.SetError(txbUserName, null);
                }
            }
            // case Update User 
            else
            {
                // If User Change His User Name
                if (_User._UserName!=txbUserName.Text.Trim())
                {
                    // Make Sure User Name He Choose Is Not Exist.
                    if (clsUsers.IsExist(txbUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txbUserName, "User Name Is Used By Another User");

                    }
                    else
                    {
                        errorProvider1.SetError(txbUserName, null);
                    }
                }
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

            _User._PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User._UserName= txbUserName.Text.Trim();
            _User._Password= txbPassword.Text.Trim();
            _User._IsActive= chbIsActive.Checked;
            if (_User.Save())
            {
                lblUserIDValue.Text = _User._UserID.ToString();
                _Mode = enMode.Update;
                lblAddUpdateUser.Text = "Update User";
                this.Text= "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
