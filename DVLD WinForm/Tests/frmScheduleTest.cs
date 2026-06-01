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

namespace DVLD_WinForm.Tests
{
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private int _TestAppointmentID = -1;
        private clsTestTypes.enTestType _TestType=clsTestTypes.enTestType.VisionTest;
        public frmScheduleTest(int LocalDrivingLicenseApplicationID,clsTestTypes.enTestType TestType,int TestAppointmentID=-1)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            _TestAppointmentID= TestAppointmentID;
            _TestType= TestType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID = _TestType;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseApplicationID, _TestAppointmentID);
        }

    }
}
