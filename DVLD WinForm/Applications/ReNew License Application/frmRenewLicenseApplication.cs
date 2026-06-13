using DVLD_BusinessLayer;
using DVLD_WinForm.Global_classes;
using DVLD_WinForm.Licenses.Local_Licens;
using DVLD_WinForm.Licenses.Local_Licens.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Applications.ReNew_License_Application
{
    public partial class frmRenewLicenseApplication : Form
    {
       
        int _OldLicenseID;
        int _NewLicenseID;
        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicensInfoWithFilter1_OnLicenseSelected(int obj)
        {

            _OldLicenseID=obj;
            lblOldLicenseID.Text = _OldLicenseID.ToString();
            if (_OldLicenseID==-1)
            {
                return; 
            }

            int DefaultValidityLength = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.licenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text=clsFormat.DateToShort( DateTime.Now.AddYears(DefaultValidityLength));
            lblApplicationFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.RenewDrivingLicense)._ApplicationFees.ToString();
            lblLicenseFees.Text = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.licenseClassInfo.ClassFees.ToString();
            lblTotalFees.Text=((Convert.ToSingle(lblApplicationFees.Text))+ (Convert.ToSingle(lblLicenseFees.Text))).ToString();
            txtNotes.Text = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.Notes;
            if (!ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + clsFormat.DateToShort(ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)
                   , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;

            }
            if (!ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                  , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsLicenses NewLicense = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text.Trim(), clsGlobal.CurrentUser._UserID);

            if (NewLicense == null )
            {
                MessageBox.Show("Failed to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lblRenewApplicationID.Text = NewLicense.ApplicationID.ToString();
            lblOldLicenseID.Text = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            lblNewLicenseID.Text= NewLicense.LicenseID.ToString();
            lblApplicationDate.Text=clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text= clsFormat.DateToShort(DateTime.Now);
            _NewLicenseID = NewLicense.LicenseID;
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRenew.Enabled = false;
            ctrlDriverLicensInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRenewLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicensInfoWithFilter1.txtLicenseIDFocus();

        }

        private void ctrlDriverLicensInfoWithFilter1_Load(object sender, EventArgs e)
        {
            ctrlDriverLicensInfoWithFilter1.txtLicenseIDFocus();


            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "???";
            lblApplicationFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.RenewDrivingLicense)._ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser._UserName;
            llShowLicenseInfo.Enabled = false;

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }
    }
}
