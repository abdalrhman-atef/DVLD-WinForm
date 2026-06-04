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
    public partial class ctrlScheduledTest : UserControl
    {
        private clsTestTypes.enTestType _TestTypeID;
        private int _TestID = -1;

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

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
                            pbTestType.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestTypes.enTestType.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            pbTestType.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestTypes.enTestType.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            pbTestType.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        private int _TestAppointmentID = -1;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointment _TestAppointment;

        public ctrlScheduledTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID) 
        {
            _TestAppointmentID=TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment==null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;

            }
            _TestTypeID = _TestAppointment.TestTypeID;
            _TestID = _TestAppointment.TestID;
            _LocalDrivingLicenseApplicationID=_TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblApplicantName.Text= _LocalDrivingLicenseApplication.ApplicantFullName.ToString();

            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest( _TestTypeID).ToString();

            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();




        }




    }
}
