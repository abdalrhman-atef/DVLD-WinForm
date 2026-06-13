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
using static DVLD_BusinessLayer.clsLicenses;

namespace DVLD_WinForm.Applications.Replace_Lost_Or_Damage_License
{
    public partial class frmReplaceLostOrDamageLicense : Form
    {
        int _OldLicenseID = -1;
        int _NewLicenseID = -1;

        public frmReplaceLostOrDamageLicense()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicensInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _OldLicenseID=obj;
            lblOldLicenseID.Text= _OldLicenseID.ToString();
            if (_OldLicenseID==-1)
            {
                return;
            }
            if (!ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                   , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }
            btnIssueReplacement.Enabled= true;
        }

        private void frmReplaceLostOrDamageLicense_Load(object sender, EventArgs e)
        {

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser._UserName;

           rbDamage .Checked = true;
        }
        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (rbDamage.Checked)

                return (int)clsApplications.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplications.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamage.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }

        private void rbDamage_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationTypes.FindApplicationType(_GetApplicationTypeID())._ApplicationFees.ToString();
        
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Lost License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationTypes.FindApplicationType(_GetApplicationTypeID())._ApplicationFees.ToString();

        }

        private void frmReplaceLostOrDamageLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicensInfoWithFilter1.txtLicenseIDFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void btnIssueReplacment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            clsLicenses NewLicense = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.ReplaceLicense(_GetIssueReason(), clsGlobal.CurrentUser._UserID);
            if (NewLicense==null)
            {
                MessageBox.Show("Failed to Issue a replacement for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            lblLostOrDamageApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            lblNewLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrlDriverLicensInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;

        }
    }
}
