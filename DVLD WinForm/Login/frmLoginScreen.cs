using DVLD_BusinessLayer;
using DVLD_WinForm.Global_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLD_WinForm
{
    public partial class frmLoginScreen : Form
    {
        private clsUsers _User;
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        private void _Reset() 
        {
            txbPassword.Text = "";
            txbUserName.Text = "";
            chkRememberMe.Checked = false;
            txbUserName.Focus();
        
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";
            if (clsGlobal.GetStoredCredential(ref UserName,ref Password))
            {
                txbUserName.Text = UserName;
                txbPassword.Text = Password;
                chkRememberMe.Checked = true;

            }
            else
            {
                txbUserName.Text = "";
                txbPassword.Text = "";
                chkRememberMe.Checked = false;

            }

        }

        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User= clsUsers.FindByUserNameAndPassword(txbUserName.Text.Trim(),txbPassword.Text.Trim());
            if (_User==null)
            {
                txbUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                if (chkRememberMe.Checked)
                {

                    clsGlobal.RememberUsernameAndPassword(txbUserName.Text.Trim(), txbPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                if (!_User._IsActive)
                {

                    txbUserName.Focus();
                    MessageBox.Show("Your Account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }
                else
                {
                    clsGlobal.CurrentUser = _User;
                   
                    frmMain frm = new frmMain(this);
                    this.Hide();
                    frm.ShowDialog();
                   
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
