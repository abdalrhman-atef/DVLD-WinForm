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

namespace DVLD_WinForm.Tests.Controls
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID = -1;
        private clsTestTypes.enTestType _TestType;
        private int _TestID = -1;
        private clsTest Test;

        public frmTakeTest(int AppointmentID, clsTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID=AppointmentID;
            _TestType=TestType;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {

            ctrlScheduledTest1.LoadInfo(_AppointmentID);
            if (ctrlScheduledTest1.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
            int TestID = ctrlScheduledTest1.TestID;
            if (TestID == -1)
            {
                Test = new clsTest();
            }
            else
            {
                _TestID = TestID;
                Test = clsTest.Find(TestID);
                if (Test.TestResult)
                {
                    rbPass.Checked=true;
                }
                else
                {
                    rbFail.Checked = true;
                }
               txbNotes.Text= Test.Notes;
                lblUserMessage.Visible= true;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
            )
            {
                return;
            }
            Test.TestAppointmentID = _AppointmentID;
            if (rbPass.Checked)
            {
                Test.TestResult = true;
            }
            else
            {
                Test.TestResult = false;
            }

            Test.Notes = txbNotes.Text;
            Test.CreatedByUserID = clsGlobal.CurrentUser._UserID;
            if (Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
