using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enMode Mode = enMode.AddNew;
        public int _ApplicationID { get; set; }
        public int _ApplicantPersonID { get; set; }
        public string ApplicantFullName
        {
            get
            {
                return clsPeople.Find(_ApplicantPersonID).FullName;
            }
        }
        public DateTime _AppDate { get; set; }
        public int _AppTypeID { get; set; }
        public enum enStatus { New = 1, Cancelled = 2, Completed = 3 }
       
        public clsApplications.enStatus _AppStatus {  get; set; }
        public string StatusText
        {
            get
            {

                switch (_AppStatus)
                {
                    case enStatus.New:
                        return "New";
                    case enStatus.Cancelled:
                        return "Cancelled";
                    case enStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }

        public DateTime _LastStatusDate { get; set; }
        public float _PaidFees { get; set; }
        public int _CreatedByUser { get; set; }
        public clsApplicationTypes _ApplicationTypeInfo { get; set; }
        public clsPeople _PersonInfo { get; set; }
        public clsUsers _CreatedByUserInfo { get; set; }
        public clsApplications()
        {
            this._ApplicationID = -1; this._ApplicantPersonID = -1; this._AppDate = new DateTime();
            this._AppTypeID = -1; this._AppStatus = enStatus.New;
            this._LastStatusDate =  DateTime.Now;
            this._PaidFees = -1;
            this._CreatedByUser = -1;
            Mode = enMode.AddNew;


        }
        private clsApplications(int ApplicationID,  int ApplicantPersonID,  DateTime ApplicationDate
            ,  int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this._ApplicationID=ApplicationID;
            this._ApplicantPersonID=ApplicantPersonID;
            this._AppDate=ApplicationDate;
            this._AppTypeID=ApplicationTypeID;
            this._AppStatus = (enStatus)ApplicationStatus;
            this._LastStatusDate=LastStatusDate;
            this._PaidFees=PaidFees;
            this._CreatedByUser = CreatedByUserID;
            this._ApplicationTypeInfo = clsApplicationTypes.FindApplicationType(_AppTypeID);
            this._PersonInfo = clsPeople.Find(ApplicantPersonID);
            this._CreatedByUserInfo = clsUsers.FindByUserID(CreatedByUserID);
            Mode = enMode.Update;
        }

        public static DataTable ListApplications() 
        {
        
        return clsApplicationsData.GetAllAplications();
        
        }
        public static clsApplications FindBaseApplicationByID(int AppID) 
        {
          
            DateTime ApplicationDate = new DateTime(), LastStatusDate = new DateTime();
            int ApplicantPersonID=-1, ApplicationTypeID=-1, CreatedByUserID = -1;
            byte ApplicationStatus = 4;
            float PaidFees = -1;
            if (clsApplicationsData.GetApplicationByAppID(AppID,ref ApplicantPersonID, ref ApplicationDate
                , ref ApplicationTypeID,ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID))
            {
                return new clsApplications(AppID, ApplicantPersonID, ApplicationDate, ApplicationTypeID
                    , ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }
        private bool _UpdateApplication()
        {
            

            return clsApplicationsData.UpdateAplications(this._ApplicationID, this._ApplicantPersonID, this._AppDate,
                this._AppTypeID, (byte)this._AppStatus,
                this._LastStatusDate, this._PaidFees, this._CreatedByUser);

        }

        private bool _AddNewApplication() 
        {
        this._ApplicationID= clsApplicationsData.AddNewApplication(this._ApplicantPersonID,this._AppDate,this._AppTypeID,
            (byte) this._AppStatus, this._LastStatusDate,this._PaidFees,this._CreatedByUser);
        return(this._ApplicationID!=-1);
        
        }
        public bool Cancel()

        {
            return clsApplicationsData.UpdateStatus(_ApplicationID, 2);
        }
        public bool SetComplete()

        {
            return clsApplicationsData.UpdateStatus(_ApplicationID, 3);
        }
        public bool Delete()
        {
            return clsApplicationsData.DeleteApplication(this._ApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }

            return false;
        }
        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationsData.IsApplicationExist(ApplicationID);
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationsData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }

        public bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
        {
            return DoesPersonHaveActiveApplication(this._ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID, clsApplications.enApplicationType ApplicationTypeID)
        {
            return clsApplicationsData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplications.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationsData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        public int GetActiveApplicationID(clsApplications.enApplicationType ApplicationTypeID)
        {
            return GetActiveApplicationID(this._ApplicantPersonID, ApplicationTypeID);
        }





    }
}
