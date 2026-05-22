using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsApplicationTypes
    {
       
        public int _ApplicationTypeID 
        {
            get;
            set;
        }
        public string _ApplicationTitle
        {
            get;
            set;
        }
        public float _ApplicationFees
        {
            get;
            set;
        }
        public enum enMode {AddNew=0,Update=1 }
        public enMode _Mode=enMode.AddNew ;
        public clsApplicationTypes() 
        {
            _Mode= enMode.AddNew;
            _ApplicationTypeID = -1;
            _ApplicationTitle = "";
            _ApplicationFees = -1;
        }
        private clsApplicationTypes(int ApplicationTypeID, string ApplicationTitle, float ApplicationFees) 
        {
            _Mode= enMode.Update;
            _ApplicationTypeID= ApplicationTypeID;
            _ApplicationTitle= ApplicationTitle;
            _ApplicationFees= ApplicationFees;
        }

        public static DataTable ListApplicationTypes() 
        {
        return clsApplicationTypesData.GetAllApplicationTypes();
        
        
        }
        public static clsApplicationTypes FindApplicationType(int ApplicationID) 
        {
            string AppTitle = ""; float ApplicationFees = -1;
            if (clsApplicationTypesData.GetApplicationTypeInfoByID(ApplicationID,ref AppTitle,ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationID, AppTitle, ApplicationFees);


            }
            else
            {
                return null;
            }



        }
        private bool _UpdateApplicationType() 
        {
            return (clsApplicationTypesData.UpdateApplicationType(this._ApplicationTypeID, this._ApplicationTitle, this._ApplicationFees));
           

        }
        private bool _AddNewApplicationType() 
        {

         this._ApplicationTypeID= clsApplicationTypesData.AddNewApplicationType(this._ApplicationTitle, this._ApplicationFees);
            return (this._ApplicationTypeID != -1);
        
        
        }

        public  bool Save() 
        {
        switch(_Mode)
           
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {

                       _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationType();

            }

            return false;


        }
        
        
        
    }
}
