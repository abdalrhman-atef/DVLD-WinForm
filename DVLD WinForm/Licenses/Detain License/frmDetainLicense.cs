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

namespace DVLD_WinForm.Licenses.Detain_License
{
    public partial class frmDetainLicense : Form
    {
        int _LicenseID = -1;
        int _DetainID=-1;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicensInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            lblLicenseID.Text = _LicenseID.ToString();
          
            if (_LicenseID == -1)
            {
                return;
            }
            if (ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {

                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            txbFineFees.Focus();
            btnDetain.Enabled = true;
            llShowLicenseInfo.Enabled = false;

        }

        private void txbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txbFineFees, null);

            }
            ;


            if (!clsValidation.IsNumber(txbFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFineFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txbFineFees, null);
            }
            ;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            btnDetain.Enabled = false;
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser._UserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            _DetainID = ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txbFineFees.Text), clsGlobal.CurrentUser._UserID); ;

            if (_DetainID == -1)
            {
                MessageBox.Show("Failed to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (!ctrlDriverLicensInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is Not Active, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text= _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            llShowLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            ctrlDriverLicensInfoWithFilter1.FilterEnabled = false;



        }

        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicensInfoWithFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }

    }
}
