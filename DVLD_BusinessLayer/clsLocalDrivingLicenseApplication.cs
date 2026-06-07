using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplication :clsApplications
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public string PersonFullName
        {
            get
            {
               
               
                return base.ApplicantFullName;
              
            }
        }
       public clsLocalDrivingLicenseApplication() 
        {

            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID=-1;
            Mode = enMode.AddNew;


        }

       private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
            clsApplications.enStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LicenseClassID) 
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID; ;
            this._ApplicationID = ApplicationID;
            this._ApplicantPersonID = ApplicantPersonID;
            this._AppDate = ApplicationDate;
            this._AppTypeID = (int)ApplicationTypeID;
            this._AppStatus = ApplicationStatus;
            this._LastStatusDate = LastStatusDate;
            this._PaidFees = PaidFees;
            this._CreatedByUser = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);

        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 

            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication
                (
                this._ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 

            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication
                (
                this.LocalDrivingLicenseApplicationID, this._ApplicationID, this.LicenseClassID);

        }
        public static clsLocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseID) 
        {
            int ApplicationID = -1, LicenseClassID = -1;
            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseID,
                ref ApplicationID, ref LicenseClassID);
            if (IsFound)
            {
                
               clsApplications application = clsApplications.FindBaseApplicationByID(ApplicationID);
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseID, ApplicationID, application._ApplicantPersonID, application._AppDate,
                    application._AppTypeID,(enStatus )application._AppStatus, application._LastStatusDate, application._PaidFees
                    , application._CreatedByUser, LicenseClassID);


            }
            else return null;


        }
        public static clsLocalDrivingLicenseApplication FindLocalDrivingAppLicenseByApplicationID(int ApplicationID) 
        {
            int LocalDrivingLicenseID = -1, LicenseClassID = -1;
            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(ApplicationID, ref LocalDrivingLicenseID, ref LicenseClassID);
            if (IsFound)
            {
                clsApplications application = clsApplications.FindBaseApplicationByID(ApplicationID);
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseID, ApplicationID, application._ApplicantPersonID, application._AppDate,
                    application._AppTypeID, (enStatus)application._AppStatus, application._LastStatusDate, application._PaidFees
                    , application._CreatedByUser, LicenseClassID);

            }
            else return null;

        }

        public bool Save() 
        {
            // first we call the save method in the base class to Take Care Of Adding Or Update Base Application.
            base.Mode = (clsApplications.enMode)Mode;
            if (!base.Save())
            {
                return false;
            }
            // After That We Save The Sub Application.
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplication();

            }

            return false;

        }

        public static DataTable GetAllLocalDrivingLicenseApplications() 
        {
        
        return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        
        }

        public bool Delete() 
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;

            // We Will Delete Local Driving License Application First
            IsLocalDrivingApplicationDeleted = clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);
            if (!IsLocalDrivingApplicationDeleted)
            {
                return false;
            }
            else
            {
                // then we will Delete The Base Application
                IsBaseApplicationDeleted = base.Delete();
                
            }
            return IsBaseApplicationDeleted;
        }
        public bool DoesPassTestType(clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public bool DoesPassPreviousTest(clsTestTypes.enTestType CurrentTestType)
        {

            switch (CurrentTestType)
            {
                case clsTestTypes.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.

                    return this.DoesPassTestType(clsTestTypes.enTestType.VisionTest);


                case clsTestTypes.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    return this.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);

                default:
                    return false;
            }
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool DoesAttendTestType(clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public byte TotalTrialsPerTest(clsTestTypes.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public bool AttendedTest(clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestTypes.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public clsTest GetLastTestPerTestType(clsTestTypes.enTestType TestTypeID)
        {
            return clsTest.FindLastTestPerPersonAndLicenseClass(this._ApplicantPersonID, this.LicenseClassID, TestTypeID);
        }

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public bool PassedAllTests()
        {
            return clsTest.ISPassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return clsTest.ISPassedAllTests(LocalDrivingLicenseApplicationID);
        }

        public int IssueLicenseForFirstTime(string Notes,int CreatedByUserID) 
        {
            int DriverID = -1;
            clsDriver Driver = clsDriver.FindByPersonID(this._ApplicantPersonID);
            // we check if the driver already there for this person.
            if (Driver!=null)
            {
                DriverID = Driver.DriverID;

            }
            else
            {
                // else We Make This Person A driver Before Issue A License .
                Driver = new clsDriver();
                Driver.CreatedDate= DateTime.Now;
                Driver.CreatedByUserID= CreatedByUserID;
                Driver.PersonID = this._ApplicantPersonID;
                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                   return  -1;
                }
            }
            
            bool IsPersonHaveLicense = clsLicenses.IsPersonHaveActiveLicense(this._ApplicantPersonID, this.LicenseClassID);

            if (IsPersonHaveLicense)
            {
                return -1;
                
            }

            else
            {
                clsLicenses License = new clsLicenses();
                License.ApplicationID = this._ApplicationID;
                License.DriverID = DriverID;
                License.LicenseClassID = this.LicenseClassID;
                License.IssueDate = DateTime.Now;
                License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
                License.Notes = Notes;
                License.PaidFees = this.LicenseClassInfo.ClassFees;
                License.IsActive = true;
                License.IssueReason = clsLicenses.enIssueReason.FirstTime;
                License.CreatedByUserID = CreatedByUserID;
                if (License.Save())
                {
                    this.SetComplete();
                    return License.LicenseID;
                }
                else
                {
                    return -1;
                }
            }


        }
        public int GetActiveLicenseID() 
        {
            return clsLicenses.GetActiveLicenseIDByPersonID(this._ApplicantPersonID, this.LicenseClassID);
        
        }
        public bool IsLicenseIssued() 
        {

            return( GetActiveLicenseID() != -1);


        }

    }
}
