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

namespace DVLD_WinForm.Applications.Release_License
{
    public partial class frmReleaseLicense : Form
    {
        int _LicenseID = -1;

        public frmReleaseLicense()
        {
            InitializeComponent();
        }

        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            ctrlDriverLicensInfoWithFilter1.LoadLicenseInfo(LicenseID);
            ctrlDriverLicensInfoWithFilter1.FilterEnabled = false;

        }

        private void ctrlDriverLicensInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            if (_LicenseID == -1)

            {
                return;
            }
            if (!ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                btnRelease.Enabled = false;
                MessageBox.Show("Selected License is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblLicenseID.Text = _LicenseID.ToString();
            lblDetainID.Text = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DetainLicenseInfo.DetainID.ToString();
            lblDetainDate.Text = clsFormat.DateToShort(ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DetainLicenseInfo.DetainDate);
            lblCreatedBy.Text = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DetainLicenseInfo.CreatedByUserInfo._UserName;
            lblFineFees.Text = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.DetainLicenseInfo.FineFees.ToString();
            lblApplicationFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.ReleaseDetainedDrivingLicsense)._ApplicationFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();
            btnRelease.Enabled = true ;

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int ApplicationID = -1;

           bool IsReleased = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.Release(clsGlobal.CurrentUser._UserID, ref ApplicationID);
            lblApplicationID.Text = ApplicationID.ToString();
            if (!IsReleased)
            {
                MessageBox.Show("Failed to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlDriverLicensInfoWithFilter1.FilterEnabled = false;
            lblShowLicenseInfo.Enabled = true;
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }

        private void frmReleaseLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicensInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
