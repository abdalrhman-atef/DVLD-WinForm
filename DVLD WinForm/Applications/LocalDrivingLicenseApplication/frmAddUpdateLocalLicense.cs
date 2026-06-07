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

namespace DVLD_WinForm.LocalDrivingLicenseApplication
{
    public partial class frmAddUpdateLocalLicense : Form
    {
        private  int _LocalDrivingApplicationID=-1;
        private clsLocalDrivingLicenseApplication _LocalDrivingApplication;
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _SelectedPersonID = -1;
        public frmAddUpdateLocalLicense()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalLicense(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingApplicationID= LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }

        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);
            }
        }

        private void _ResetDefaultValues() 
        {
            _FillLicenseClassesInComboBox();
            if (_Mode==enMode.AddNew)
            {

                lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingApplication= new clsLocalDrivingLicenseApplication();
                ctrlPersonCardWithFilter1.FilterFocus();
                tpAppInfo.Enabled = false;
                cbLicenseClasses.SelectedIndex = 2;
                LblAppFees.Text= clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.NewDrivingLicense)._ApplicationFees.ToString();
                lblAppDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = clsGlobal.CurrentUser._UserName;
                btnSave.Enabled = false;

            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";

                tpAppInfo.Enabled = true;
                btnSave.Enabled = true;


            }



        }
        private void _LoadData()
        {

            ctrlPersonCardWithFilter1.FilterEnabled = false;
            _LocalDrivingApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingApplicationID);

            if (_LocalDrivingApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingApplication._ApplicantPersonID);
            lblApplicationIDValue.Text = _LocalDrivingApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppDate.Text = clsFormat.DateToShort(_LocalDrivingApplication._AppDate);
            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(clsLicenseClass.Find(_LocalDrivingApplication.LicenseClassID).ClassName);
            LblAppFees.Text = _LocalDrivingApplication._PaidFees.ToString();
            lblCreatedBy.Text = clsUsers.FindByUserID(_LocalDrivingApplication._CreatedByUser)._UserName;

        }
        private void frmAddUpdateLocalLicense_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode==enMode.Update)
            {
                
                _LoadData();
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // In Case Update Local Driving Application 
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpAppInfo.Enabled = true;
                TcLocalDrivingApplication.SelectedTab = TcLocalDrivingApplication.TabPages["tpAppInfo"];
                return;

            }

            // In Case Add New Local Driving Application
            if (ctrlPersonCardWithFilter1.PersonID!=-1)
            {
                btnSave.Enabled = true;
                tpAppInfo.Enabled = true;
                TcLocalDrivingApplication.SelectedTab = TcLocalDrivingApplication.TabPages["tpAppInfo"];

            }
            else
            {

                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            int LicenseClassID = clsLicenseClass.Find(cbLicenseClasses.Text).LicenseClassID;

            //Here We Search If This Person Have An Active Application suchLike This Application Type And This Class Or Not.
            int ActiveApplicationID = clsApplications.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplications.enApplicationType.NewDrivingLicense, LicenseClassID);
            if (ActiveApplicationID !=-1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClasses.Focus();
                return;
            }

            if (clsLicenses.IsPersonHaveActiveLicense(ctrlPersonCardWithFilter1.PersonID, LicenseClassID)) 
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingApplication._ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;
            _LocalDrivingApplication._AppDate= DateTime.Now;
            _LocalDrivingApplication._AppTypeID =(int) clsApplications.enApplicationType.NewDrivingLicense;
            _LocalDrivingApplication._AppStatus = clsApplications.enStatus.New;
            _LocalDrivingApplication._LastStatusDate= DateTime.Now;
            _LocalDrivingApplication._PaidFees = Convert.ToSingle(LblAppFees.Text);
            _LocalDrivingApplication._CreatedByUser = clsGlobal.CurrentUser._UserID;
            _LocalDrivingApplication.LicenseClassID = LicenseClassID;
            if (_LocalDrivingApplication.Save())
            {
                lblApplicationIDValue.Text= _LocalDrivingApplication.LocalDrivingLicenseApplicationID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Local Driving License Application";
                this.Text= "Update Local Driving License Application";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void frmAddUpdateLocalLicense_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
