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

namespace DVLD_WinForm.Licenses.Local_Licens.Controls
{
    public partial class ctrlDriverLicensInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler!=null)
            {
                handler(LicenseID);
            }


        } 

        public ctrlDriverLicensInfoWithFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; } 
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        private int _LicenseID = -1;
        public int LicenseID
        {
            get
            {  return ctrlDriverLicenseInfo1.LicenseID; }
        }

        public clsLicenses SelectedLicenseInfo
        {
            get
            {
                return ctrlDriverLicenseInfo1.SelectedLicenseInfo;
            }

        }


        public void LoadLicenseInfo(int LicenseID)
        {
            txbFilterValue.Text = LicenseID.ToString();
            
            ctrlDriverLicenseInfo1.LoadInfo(LicenseID);

            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;
            if (OnLicenseSelected!=null&&FilterEnabled)
            {
                OnLicenseSelected(_LicenseID);
            }
        }

        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }
        }

        private void txbFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txbFilterValue, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbFilterValue.Focus();
                return;

            }
            _LicenseID = int.Parse(txbFilterValue.Text);
            LoadLicenseInfo(_LicenseID);
        }

        public void txtLicenseIDFocus() 
        {

            txbFilterValue.Focus();
        
        }



    }
}
