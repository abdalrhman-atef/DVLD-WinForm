using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsUsers
    {
        public int _UserID {  get; set; }
        public int _PersonID {  get; set; }
        public string _UserName { get; set; }
        public bool _IsActive { get; set; }
        public string _Password { get; set; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;
        clsPeople _PersonInfo;
        public clsUsers() 
        {
           this._UserID = -1;
           this._UserName = "";
            this._PersonID = -1;
           this._IsActive=false;
           this._Password = "";
           this. _Mode = enMode.AddNew;
         


        }
        private clsUsers(int UserID,int PersonID, string UserName ,string Password ,bool IsActive) 
        {
             this._UserID=UserID;
             this._PersonID=PersonID;
             this._UserName=UserName;
             this._Password = Password;
             this._IsActive =IsActive;
             this._Mode=enMode.Update;
            this._PersonInfo = clsPeople.Find(PersonID);



        }

        public static DataTable UsersList() 
        {
          return clsUsersData.GetAllUsers();
        }
        private bool _AddNewUser()
        {
            if (IsExistByPersonID(_PersonID))
            {
                return false;
            }
            else
            {
                this._UserID = clsUsersData.AddNewUser(this._PersonID, this._UserName, this._Password, this._IsActive);
                return (this._UserID != -1);

            }


        }

        private bool _UpdateUser() 
        {
        
            return clsUsersData.UpdateUser(this._UserID,this._PersonID,this._UserName,this._Password,this._IsActive);


        
        
        }

        public bool Save() 
        {
       
            switch(_Mode)
            {
                case enMode.AddNew:
                    return _AddNewUser();

                case enMode.Update:
                        return _UpdateUser();


            }
            return false;
        
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            string UserName = ""; int UserID = -1; string Password = ""; bool IsActive = false;
            if (clsUsersData.FindUserByPersonID( PersonID, ref UserID,ref  UserName, ref Password, ref IsActive))
            {
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);

            }
            else
            {
                return null;
            }
        }
        public static clsUsers FindByUserID (int UserID)
        {
            int PersonID = -1;string UserName = "", Password = "";bool IsActive = false;
            if (clsUsersData.FindUserByUserID(UserID,ref PersonID, ref UserName,ref Password, ref IsActive)) 
            {
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
            
            }
            else
            {
                return null;
            }
        }
        public static clsUsers FindByUserNameAndPassword(string UserName, string Password)
        {
            int PersonID = -1; int UserID = -1; bool IsActive = false;
            if (clsUsersData.FindUserByUserNameAndPassword(ref UserID, ref PersonID,  UserName,  Password, ref IsActive))
            {
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);

            }
            else
            {
                return null;
            }
        }
        public static bool Delete(int UserID) 
        {
        return clsUsersData.DeleteUser(UserID);
        
        
        }
     
        public static bool IsExist(int UserID)
     
        {
            return clsUsersData.IsUserExist(UserID);





     
        }
        public static bool IsExistByPersonID(int PersonID)

        {
            return clsUsersData.IsUserExistByPersonID(PersonID);






        }

        public static bool IsExist(string  UserName)

        {
            return clsUsersData.IsUserExist(UserName);

        }
        public bool ChangePassword(string NewPassword) 
        {
            if (clsUsersData.ChangePassword(this._UserID,NewPassword))
            {
                
                this._Password= NewPassword;
                return true;
            }
            return false;
        }



    }
}
