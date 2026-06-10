using DVLD_WinForm.Applications;
using DVLD_WinForm.Applications.LocalDrivingLicenseApplication;
using DVLD_WinForm.Drivers;
using DVLD_WinForm.Global_classes;
using DVLD_WinForm.LocalDrivingLicenseApplication;
using DVLD_WinForm.People;
using DVLD_WinForm.Tests;
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

        private void picForm_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void ManageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestTypesList frm = new frmTestTypesList();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalLicense frm = new frmAddUpdateLocalLicense();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
            frm.ShowDialog();

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();

        }
    }
}
