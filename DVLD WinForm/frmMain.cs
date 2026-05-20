using DVLD_WinForm.Global_classes;
using DVLD_WinForm.People;
using DVLD_WinForm.Users;
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
    public partial class frmMain : Form
    {
        frmLoginScreen frmLoginScreen;
        
        public frmMain(frmLoginScreen frm)
        {
            InitializeComponent();
            frmLoginScreen=frm;
            this.ControlBox = false;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeopleList();
            frm.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList usersList = new frmUsersList();
            usersList.ShowDialog();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUser = new frmUserInfo(clsGlobal.CurrentUser._UserID);
            frmUser.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(clsGlobal.CurrentUser._UserID);
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            frmLoginScreen.Show();
            this.Close();


        }

        
    }
}
