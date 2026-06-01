using DVLD_BusinessLayer;
using DVLD_WinForm.Global_classes;
using DVLD_WinForm.Properties;
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
    public partial class ctrlScheduleTest : UserControl
    {

        private int _TestAppointmentID = -1;
        private clsTestAppointment _TestAppointment;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;
        public clsTestTypes.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestTypes.enTestType.VisionTest:
                        {
                            gbTestType.Text = "Vision Test";
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestTypes.enTestType.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestTypes.enTestType.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }
        public ctrlScheduleTest()
        {
            InitializeComponent();
        }
        private bool _LoadTestAppointmentData() 
        {
            _TestAppointment=clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }
            lblFees.Text= _TestAppointment.PaidFees.ToString();
            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpTestDate.MinDate = DateTime.Now;
            else
                dtpTestDate.MinDate = _TestAppointment.AppointmentDate;
            dtpTestDate.Value = _TestAppointment.AppointmentDate;
            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                lblRetakeAppFees.Text = _TestAppointment.RetakeTestAppInfo._PaidFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;


        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lblUserMessage.Visible = false;

            return true;
        }
        private bool _HandlePreviousTestConstraint()
        {
            //we need to make sure that this person passed the previous required test before apply to the new test.
            //person can not apply for written test unless  passes the vision test.
            //person cannot apply for street test unless  passes the written test.

            switch (TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    //in this case no required previous test to pass.
                    lblUserMessage.Visible = false;

                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    //Written Test, you cannot schedule it before person passes the vision test.
                    //we check if pass vision test 1.
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest))
                    {
                        lblUserMessage.Text = "Cannot schedule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

                case clsTestTypes.enTestType.StreetTest:

                    //Street Test, you can not schedule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest))
                    {
                        lblUserMessage.Text = "Cannot schedule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

            }
            return true;

        }
        private bool _HandleRetakeApplication()
        {
            //this will decide to create an application for retake test or not.
            // and will create it if needed , then it will link it to the appointment.
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                 
                clsApplications Application = new clsApplications();

                Application._ApplicantPersonID = _LocalDrivingLicenseApplication._ApplicantPersonID;
                Application._AppDate = DateTime.Now;
                Application._AppTypeID = (int)clsApplications.enApplicationType.RetakeTest;
                Application._AppStatus = clsApplications.enStatus.Completed;
                Application._LastStatusDate = DateTime.Now;
                Application._PaidFees = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.RetakeTest)._ApplicationFees;
                Application._CreatedByUser = clsGlobal.CurrentUser._UserID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Failed to Create application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application._ApplicationID;

            }
            return true;
        }
        public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
            if (AppointmentID==-1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
            _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            _TestAppointmentID= AppointmentID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            if (_LocalDrivingLicenseApplication.DoesAttendTestType(TestTypeID))
            {
                _CreationMode = enCreationMode.RetakeTestSchedule;
            }
            else
            {
                _CreationMode = enCreationMode.FirstTimeSchedule;
            }
            if (_CreationMode==enCreationMode.RetakeTestSchedule)
            {

                lblRetakeAppFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.RetakeTest)._ApplicationFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = "0";
            }
            else
            {
                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            lblLocalDrivingLicenseID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApplication.PersonFullName;
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();

            if (_Mode==enMode.AddNew)
            {
                lblFees.Text= clsApplicationTypes.FindApplicationType((int)_TestTypeID)._ApplicationFees.ToString() ;
                dtpTestDate.MinDate = DateTime.Now;
                lblRetakeTestAppID.Text = "N/A";
                _TestAppointment= new clsTestAppointment();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                {
                    return;
                }
                

            }

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeAppFees.Text)).ToString();
            if (!_HandleActiveTestAppointmentConstraint())
            {
                return;

            }
            if (!_HandleAppointmentLockedConstraint())
            {
                return;
            }
            if (!_HandlePreviousTestConstraint())
            {
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
            {
                return;
            }
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser._UserID;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
