using DVLD_BusinessLayer;
using DVLD_WinForm.Global_classes;
using DVLD_WinForm.Licenses.Intrnational_Linss;
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

namespace DVLD_WinForm.Applications.International_License_Application
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        int _InterNationalLicenseID=-1;
        
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));//add one year.
            lblFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.NewInternationalLicense)._ApplicationFees.ToString();
            lblCreatedByUserID.Text = clsGlobal.CurrentUser._UserName;
            llShowLicenseInfo.Enabled=false;

        }

        private void ctrlDriverLicensInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LocalLicenseSelected = obj;

            lblLocalLicenseID.Text= LocalLicenseSelected.ToString();
            if (LocalLicenseSelected==-1)
            {
                return;
            }
            if (ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.LicenseClassID!=3)
            {

                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ActiveInternationalLicense = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternationalLicense!=-1)
            {

                MessageBox.Show("Person already has an active international license with ID = " + ActiveInternationalLicense.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _InterNationalLicenseID = ActiveInternationalLicense;
                btnIssue.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                return;
            }
            else
            {
                btnIssue.Enabled = true;
                llShowLicenseInfo.Enabled = false;
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicense internationalLicense =new clsInternationalLicense();

            internationalLicense._ApplicantPersonID=ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            internationalLicense._AppDate = DateTime.Now;
            internationalLicense._AppStatus= clsApplications.enStatus.Completed;
            internationalLicense._LastStatusDate= DateTime.Now;
            internationalLicense._PaidFees = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.NewInternationalLicense)._ApplicationFees;
            internationalLicense._CreatedByUser = clsGlobal.CurrentUser._UserID;


            internationalLicense.DriverID = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            internationalLicense.IssueDate= DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(+1);
            internationalLicense._CreatedByUser= clsGlobal.CurrentUser._UserID;

            if (!internationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {
                lblApplicationID.Text= internationalLicense._ApplicationID.ToString();
                lblIntLicenseAppID.Text= internationalLicense.InternationalLicenseID.ToString();
                _InterNationalLicenseID = internationalLicense.InternationalLicenseID;
                MessageBox.Show("International License Issued Successfully with ID=" + internationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssue.Enabled = false;
                ctrlDriverLicensInfoWithFilter1.FilterEnabled = false;
                llShowLicenseInfo.Enabled = true;
            }

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InterNationalLicenseID);
            frm.ShowDialog();
        }
    }
}
