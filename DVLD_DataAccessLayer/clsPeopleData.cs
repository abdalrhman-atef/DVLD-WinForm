using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace DVLD_DataAccessLayer
{
    public class clsPeopleData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo,
            ref string FirstName, ref string SecondName, ref string ThirdName
            , ref string LastName, ref DateTime DateOfBirth, ref int Gender,
            ref string Address, ref string Phone, ref string Email,
            ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM [dbo].[People] WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];

                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;



        }
        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
         ref short Gendor, ref string Address, ref string Phone, ref string Email,
         ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);


            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName
            , string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email,
             int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(DVLD_DataAccessLayer.clsDVLD_DataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO [dbo].[People] (NationalNo,FirstName ,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) VALUES (@NationalNo,@FirstName ,@SecondName,@ThirdName,@LastName, @DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath) ; SELECT SCOPE_IDENTITY(); ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", SqlDbType.TinyInt).Value = Gendor;
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();

            }
            return PersonID;


        }
        public static bool UpdatePersonInfoByID(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName
            , string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email,
             int NationalityCountryID, string ImagePath)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[People] SET [NationalNo] = @NationalNo   " +
                "  ,[FirstName] = @FirstName" +
                ",[SecondName] = @SecondName" +
                " ,[ThirdName] = @ThirdName," +
                "[LastName] = @LastName, " +
                "[DateOfBirth] = @DateOfBirth," +
                "[Gendor] = @Gendor, " +
                "[Address] = @Address, " +
                "[Phone] = @Phone, " +
                "[Email] = @Email, " +
                "[NationalityCountryID] = @NationalityCountryID, " +
                "[ImagePath] = @ImagePath " +
                " WHERE PersonID = @PersonID ;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                int RowAffected = command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    IsUpdated = true;

                }
                else
                {
                    IsUpdated = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                IsUpdated = false;

            }
            finally
            {
                connection.Close();

            }
            return IsUpdated;



        }
        public static DataTable GetAllPeople()
        {
            DataTable DT = new DataTable();
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, " +
                " People.DateOfBirth,case when People.Gendor=0 then 'male' else 'female' end as GenderCaption, " +
                "People.Address,People.Phone, People.Email,Countries.CountryName,People.ImagePath " +
                "FROM     People INNER JOIN  Countries ON People.NationalityCountryID = Countries.CountryID" +
                " order by People.FirstName ";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DT.Load(reader);
                }
                reader.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);


            }
            finally
            {
                connection.Close();
            }

            return DT;


        }
        public static bool DeletePerson(int PersonID)
        {
            int RowEffected = -1;


            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "DELETE FROM [dbo].[People] WHERE @PersonID = PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();

                RowEffected = command.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);


            }
            finally
            {
                connection.Close();
            }
            return (RowEffected > 0);


        }
        public static bool IsPersonExist(int PersonID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select Found=1 from People where People.PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                IsFound = false;

            }
            finally
            {
                connection.Close();
            }
            return IsFound;

        }
        public static bool IsPersonExist(string NationalNo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "select Found=1 from People where People.NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                IsFound = false;

            }
            finally
            {
                connection.Close();
            }
            return IsFound;

        }


    }
}
