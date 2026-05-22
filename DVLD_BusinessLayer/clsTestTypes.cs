using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestTypes
    {

        public int _TestTypeID {  get; set; }
        public string _TestTypeTitle { get; set; }
        public string _TestTypeDescription { get; set; }
        public float _TestTypeFees { get; set; }
        public enum enMode  {AddNew=0,Update=1 }
        public enMode _Mode= enMode.AddNew;

        public clsTestTypes() 
        {
            this._TestTypeID = -1;
            this._TestTypeTitle = "";
            this._TestTypeDescription = "";
            this._TestTypeFees = -1;
            _Mode= enMode.AddNew;


        }

        private clsTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription,float TestFees) 
        {
            _Mode= enMode.Update;
            this._TestTypeID = TestTypeID;
            this._TestTypeTitle= TestTypeTitle;
            this._TestTypeDescription= TestTypeDescription;
            this._TestTypeFees= TestFees;


        }


        public static DataTable TestTypesList() 
        {
            return clsTestTypesData.GetAllTestTypes();

        
        }

        public static clsTestTypes Find(int TestTypeID) 
        {
            string TestTypeTitle = ""; string TestTypeDescription = ""; float TestFees = -1;

            if (clsTestTypesData.GetTestTypeByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestFees)) 
            {
                    return new clsTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);
            }
            else
            {
                return null;
            }


        }

        private bool _UpdateTestType() 
        {
        return  clsTestTypesData.UpdateTestTypes(this._TestTypeID, this._TestTypeTitle, this._TestTypeDescription, this._TestTypeFees);
        
        }
        private bool _AddNewTestType() 
        {
        
            this._TestTypeID= clsTestTypesData.AddTestType(this._TestTypeTitle,this._TestTypeDescription,this._TestTypeFees);
            return (this._TestTypeID != -1);
        
        }

        public bool Save() 
        {

            switch (_Mode) 
            {
            case  enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return _UpdateTestType();

            }
        return false;
        
        }



    }
}
