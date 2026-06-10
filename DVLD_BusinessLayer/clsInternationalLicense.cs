using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense : clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsDriver DriverInfo;
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        public clsInternationalLicense()

        {
            //here we set the applicaiton type to New International License.
            this._AppTypeID = (int)clsApplications.enApplicationType.NewInternationalLicense;

            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;

            this.IsActive = true;


            Mode = enMode.AddNew;

        }
        private clsInternationalLicense(int ApplicationID, int ApplicantPersonID,
          DateTime ApplicationDate,
           enStatus ApplicationStatus, DateTime LastStatusDate,
           float PaidFees, int CreatedByUserID,
           int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID,
          DateTime IssueDate, DateTime ExpirationDate, bool IsActive)

        {
            //this is for the base clase
            base._ApplicationID = ApplicationID;
            base._ApplicantPersonID = ApplicantPersonID;
            base._AppDate = ApplicationDate;
            base._AppTypeID = (int)clsApplications.enApplicationType.NewInternationalLicense;
            base._AppStatus = ApplicationStatus;
            base._LastStatusDate = LastStatusDate;
            base._PaidFees = PaidFees;
            base._CreatedByUser = CreatedByUserID;

            this.InternationalLicenseID = InternationalLicenseID;
            this._ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this._CreatedByUser = CreatedByUserID;

            this.DriverInfo = clsDriver.FindByDriverID(this.DriverID);

            Mode = enMode.Update;
        }


        private bool _AddNewInternationalLicense()
        {
            //call DataAccess Layer 

            this.InternationalLicenseID =
                clsInternationalLicensesData.AddNewInternationalLicense(this._ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
               this.IssueDate, this.ExpirationDate,
               this.IsActive, this._CreatedByUser);


            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            //call DataAccess Layer 

            return clsInternationalLicensesData.UpdateInternationalLicense(
                this.InternationalLicenseID, this._ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
               this.IssueDate, this.ExpirationDate,
               this.IsActive, this._CreatedByUser);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1; int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true; int CreatedByUserID = 1;

            if (clsInternationalLicensesData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalLicenseID,
            ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                //now we find the base application
                clsApplications Application = clsApplications.FindBaseApplicationByID(ApplicationID);


                return new clsInternationalLicense(Application._ApplicationID,
                    Application._ApplicantPersonID,
                                     Application._AppDate,
                                    (enStatus)Application._AppStatus, Application._LastStatusDate,
                                     Application._PaidFees, Application._CreatedByUser,
                                     InternationalLicenseID, DriverID, IssuedUsingLocalLicenseID,
                                         IssueDate, ExpirationDate, IsActive);

            }

            else
                return null;

        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesData.GetAllInternationalLicenses();

        }

        public bool Save()
        {

            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.
            base.Mode = (clsApplications.enMode)Mode;
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInternationalLicense();

            }

            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return clsInternationalLicensesData.GetActiveInternationalLicenseIDByDriverID(DriverID);

        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicensesData.GetDriverInternationalLicenses(DriverID);
        }





    }
}
