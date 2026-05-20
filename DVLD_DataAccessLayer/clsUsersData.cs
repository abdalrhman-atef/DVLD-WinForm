using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsUsersData
    {
        public static DataTable GetAllUsers() 
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = " SELECT  Users.UserID, Users.PersonID," +
                " FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName," +
                "Users.UserName, Users.IsActive" +
                " FROM  Users INNER JOIN People ON Users.PersonID = People.PersonID;";
            SqlCommand cmd = new SqlCommand(Query, connection);

            try 
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {


            }
            finally { connection.Close(); }
            return dt;



        }
        public static int AddNewUser(int PersonID,string UserName, string Password , bool IsActive) 
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
           
            string Query = "INSERT INTO [dbo].[Users] (PersonID  ,UserName ,Password ,IsActive) VALUES (@PersonID  ,@UserName ,@Password ,@IsActive) SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;


                }

            }
        catch { }
            finally { connection.Close(); }
            return UserID;
        }
        public static bool UpdateUser(int UserID, int PersonID, string UserName,string Password, bool IsActive ) 
        {
            bool IsUpdated= false;
          
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[Users] SET [UserName] = @UserName  ,PersonID = @PersonID  ,[Password] = @Password,[IsActive] = @IsActive where UserID =@UserID;";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                int RowsEffected = command.ExecuteNonQuery();
                if (RowsEffected>0)
                {
                    IsUpdated = true;
                }
                else
                {
                    IsUpdated = false;
                }

            }
            catch {}
            finally { connection.Close(); }
            return IsUpdated;




        }

        public static bool FindUserByPersonID(int PersonID,ref int UserID, ref string UserName, ref string Password, ref bool IsActive) 
        { 
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select * from Users where PersonID =@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try 
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];




                }
                else
                {
                    IsFound = false;
                }

            }
            catch {  IsFound = false; }
            finally { connection.Close(); }
            return IsFound;



        }
        public static bool FindUserByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select * from Users where UserID =@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];




                }
                else
                {
                    IsFound = false;
                }

            }
            catch { IsFound = false; }
            finally { connection.Close(); }
            return IsFound;



        }
        public static bool FindUserByUserNameAndPassword(ref int UserID, ref int PersonID,  string UserName,  string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select * from Users where UserName =@UserName and Password=@Password";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];




                }
                else
                {
                    IsFound = false;
                }

            }
            catch { IsFound = false; }
            finally { connection.Close(); }
            return IsFound;



        }
        public static bool DeleteUser(int UserID) 
        {
            bool IsDeleted = false;
       
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "DELETE FROM [dbo].[Users] WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
              int RowsIffected=  command.ExecuteNonQuery();
                if (RowsIffected>0)
                {
                    IsDeleted = true;
                }

            }
            catch {}
            finally { connection.Close(); }
            return IsDeleted;
        }

        public static bool IsUserExist(int UserID) 
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select Found=1 from Users where Users.UserID=@UserID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsExist = reader.HasRows;
                reader.Close();


            }
            catch { }
            finally { connection.Close(); }
            return IsExist;


        }
        public static bool IsUserExist(string UserName)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select Found=1 from Users where Users.UserName=@UserName ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsExist = reader.HasRows;
                reader.Close();


            }
            catch { }
            finally { connection.Close(); }
            return IsExist;


        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select Found=1 from Users where Users.PersonID=@PersonID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsExist = reader.HasRows;
                reader.Close();


            }
            catch { }
            finally { connection.Close(); }
            return IsExist;


        }

        public static bool ChangePassword(int UserID, string Password)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


    }
}
