using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
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
               
                return base._PersonInfo.FullName;
                // or 
               // return base.ApplicantFullName;
              
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

    }
}
