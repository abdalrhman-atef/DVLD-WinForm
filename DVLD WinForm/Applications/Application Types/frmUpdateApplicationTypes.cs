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

namespace DVLD_WinForm.Applications.Application_Types
{
    public partial class frmUpdateApplicationTypes : Form
    {
        clsApplicationTypes ApplicationType;
        int _ApplicationTypeID=-1;
        public frmUpdateApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID=ApplicationTypeID;
        }

        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            lblIDValue.Text = _ApplicationTypeID.ToString();
            ApplicationType = clsApplicationTypes.FindApplicationType(_ApplicationTypeID);
            if (ApplicationType!=null)
            {
                txbTitle.Text = ApplicationType._ApplicationTitle;
                txbFees.Text = ApplicationType._ApplicationFees.ToString();

                btnSave.Focus();
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApplicationType._ApplicationTitle = txbTitle.Text.Trim();
            ApplicationType._ApplicationFees = Convert.ToSingle(txbFees.Text);
            if (ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txbFees_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txbFees, null);

            }
            ;


            if (!clsValidation.IsNumber(txbFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txbFees, null);
            }
            
        }

        private void txbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txbTitle, null);
            }
            
        }
    }
}
