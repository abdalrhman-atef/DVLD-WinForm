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

namespace DVLD_WinForm.Tests.Test_Types
{
    public partial class frmUpdateTestTypes : Form
    {
        clsTestTypes _TestType;
        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;

        public frmUpdateTestTypes(clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

     

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
          
            _TestType = clsTestTypes.Find(_TestTypeID);
            if (_TestType!=null)
            {
                lblTestTypeIdValue.Text = ((int)_TestTypeID).ToString();
                txbTestTypeTitle.Text = _TestType._TestTypeTitle.ToString();
                txbTestTypeFeees.Text= _TestType._TestTypeFees.ToString();
                txbTestTypeDescription.Text= _TestType._TestTypeDescription.ToString();
                
            }
          

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbTestTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTestTypeTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbTestTypeTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txbTestTypeTitle, null);
            }
        }

        private void txbTestTypeDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTestTypeDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbTestTypeDescription, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txbTestTypeDescription, null);
            }
        }

        private void txbTestTypeFeees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTestTypeFeees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbTestTypeFeees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txbTestTypeFeees, null);

            }
            ;


            if (!clsValidation.IsNumber(txbTestTypeFeees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbTestTypeFeees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txbTestTypeFeees, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _TestType._TestTypeTitle=txbTestTypeTitle.Text.Trim();
            _TestType._TestTypeDescription=txbTestTypeDescription.Text.Trim();
            _TestType._TestTypeFees = Convert.ToSingle(txbTestTypeFeees.Text);
            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


    }
}
