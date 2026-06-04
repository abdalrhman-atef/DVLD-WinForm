using DVLD_BusinessLayer;
using DVLD_WinForm.Properties;
using DVLD_WinForm.Tests.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsTestTypes;

namespace DVLD_WinForm.Tests
{
    public partial class frmListTestAppointments : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        clsTestTypes.enTestType _TestType=clsTestTypes.enTestType.VisionTest;
        DataTable _dtAllTestAppointments;
      
        public frmListTestAppointments(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplicationID;
            _TestType=TestTypeID;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case clsTestTypes.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestTypes.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestTypes.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }

        private void _RefreshTestAppointmentsList()
        {
            _LoadTestTypeImageAndTitle();
            ctrlLocalDrivingApplicationInfo1._LoadInfoByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID);
            _dtAllTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);
            dgvTestAppointmentsList.DataSource = _dtAllTestAppointments;
            lblRecordsCount.Text = dgvTestAppointmentsList.Rows.Count.ToString();

            if (dgvTestAppointmentsList.Rows.Count > 0)
            {
                dgvTestAppointmentsList.Columns[0].HeaderText = "Appointment ID";
                dgvTestAppointmentsList.Columns[0].Width = 150;

                dgvTestAppointmentsList.Columns[1].HeaderText = "Appointment Date";
                dgvTestAppointmentsList.Columns[1].Width = 200;

                dgvTestAppointmentsList.Columns[2].HeaderText = "Paid Fees";
                dgvTestAppointmentsList.Columns[2].Width = 150;

                dgvTestAppointmentsList.Columns[3].HeaderText = "Is Locked";
                dgvTestAppointmentsList.Columns[3].Width = 100;
            }






        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                frmScheduleTest frm1 = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm1.ShowDialog();
                frmListTestAppointments_Load(null, null);
                return;
            }

            if (LastTest.TestResult == true)
            {

                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm.ShowDialog();
                _RefreshTestAppointmentsList();
            }
            

           


          
           
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvTestAppointmentsList.CurrentRow.Cells[0].Value;
            frmScheduleTest frm =new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID);
            frm.ShowDialog();
            _RefreshTestAppointmentsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _RefreshTestAppointmentsList();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvTestAppointmentsList.CurrentRow.Cells[0].Value;
            frmTakeTest frm = new frmTakeTest(TestAppointmentID, _TestType);
            frm.ShowDialog();
            _RefreshTestAppointmentsList();
        }
    }
}
