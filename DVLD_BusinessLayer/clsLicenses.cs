using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public int LicenseID {  get; set; }

        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int LicenseClassID { get; set; }
        public clsLicenseClass licenseClassInfo;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason {  get; set; }
        public int CreatedByUserID { get; set; }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }   
        }
        private string GetIssueReasonText(clsLicenses.enIssueReason IssueReason)
        {
           
                 switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        

        }

        public clsLicenses() 
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;


        }
        private clsLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
          DateTime IssueDate, DateTime ExpirationDate, string Notes,
          float PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)

        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = clsDriver.FindByDriverID(this.DriverID);
            this.licenseClassInfo = clsLicenseClass.Find(this.LicenseClassID);
           
            Mode = enMode.Update;
        }
        private bool _AddNewLicense() 
        {
            this.LicenseID = clsLicensesData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);
        
        
        }
        private bool _UpdateLicense() 
        {
            return clsLicensesData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID,
                    this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        
        
        }

        public bool Save()
        {
            switch (Mode) 
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateLicense())
                    {
                      
                        return true;
                    }
                    else
                    {
                        return false;
                    }


            }
            return false;

        }

        public static DataTable GetAllLicense() 
        {
        return clsLicensesData.GetAllLicenses();
        
        
        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicensesData.GetDriverLicenses(DriverID);
        }
      
        public static clsLicenses Find (int LicenseID) 
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;

            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = -1;
            bool IsActive=false;
            byte  IssueReason =(byte) enIssueReason.FirstTime;
            int CreatedByUserID = -1;


            if (clsLicensesData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate,
               ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID)) 
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees
                    , IsActive, (clsLicenses.enIssueReason)IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
      
        public static int  GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            return clsLicensesData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }
        public static bool IsPersonHaveActiveLicense(int PersonID, int LicenseClassID) 
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        
        }
        public bool IsLicenseExpired() 
        {
            return (this.ExpirationDate < DateTime.Now);
        
        }
        public bool DeactivateCurrentLicense(int LicenseID) 
        {
        return clsLicensesData.DeactivateLicense(LicenseID);
        
        
        }
        public clsLicenses RenewLicense(string Notes , int CreatedByUser) 
        {
        clsApplications Application= new clsApplications();

            Application._ApplicantPersonID = this.DriverInfo.PersonID;
            Application._AppDate = DateTime.Now;
            Application._AppStatus = clsApplications.enStatus.Completed;
            Application._AppTypeID =(int) clsApplications.enApplicationType.RenewDrivingLicense;
            Application._PaidFees = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.RenewDrivingLicense)._ApplicationFees;
            Application._LastStatusDate=DateTime.Now;
            Application._CreatedByUser = CreatedByUser;
            if (!Application.Save())
            {
                return null;
            }

            clsLicenses NewLicense = new clsLicenses();
            NewLicense.ApplicationID = Application._ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(this.licenseClassInfo.DefaultValidityLength);
            NewLicense.PaidFees = this.licenseClassInfo.ClassFees;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.CreatedByUserID = CreatedByUser;
            NewLicense.Notes = Notes;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = enIssueReason.Renew;

            if (!NewLicense.Save())
            {
                return null;
            }

            DeactivateCurrentLicense(this.LicenseID);
            return NewLicense;
        }

        public clsLicenses ReplaceLicense(enIssueReason reason, int CreatedByUser)
        {
            clsApplications Application = new clsApplications();

            Application._ApplicantPersonID = this.DriverInfo.PersonID;
            Application._AppDate = DateTime.Now;
            Application._AppStatus = clsApplications.enStatus.Completed;
            if (reason==enIssueReason.LostReplacement)
            {
                Application._AppTypeID = (int)clsApplications.enApplicationType.ReplaceLostDrivingLicense;
                Application._PaidFees = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.ReplaceLostDrivingLicense)._ApplicationFees;

            }
            if (reason == enIssueReason.DamagedReplacement)
            {
                Application._AppTypeID = (int)clsApplications.enApplicationType.ReplaceDamagedDrivingLicense;
                Application._PaidFees = clsApplicationTypes.FindApplicationType((int)clsApplications.enApplicationType.ReplaceDamagedDrivingLicense)._ApplicationFees;

            }


            Application._LastStatusDate = DateTime.Now;
            Application._CreatedByUser = CreatedByUser;
            if (!Application.Save())
            {
                return null;
            }

            clsLicenses NewLicense = new clsLicenses();
            NewLicense.ApplicationID = Application._ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(this.licenseClassInfo.DefaultValidityLength);
            NewLicense.PaidFees = this.licenseClassInfo.ClassFees;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.CreatedByUserID = CreatedByUser;
            NewLicense.Notes = Notes;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = reason;

            if (!NewLicense.Save())
            {
                return null;
            }

            DeactivateCurrentLicense(this.LicenseID);
            return NewLicense;
        }

    }
}
