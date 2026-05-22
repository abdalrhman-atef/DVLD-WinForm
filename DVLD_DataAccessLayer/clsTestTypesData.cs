using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsTestTypesData
    {

        public static DataTable GetAllTestTypes() 
        {
        
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM TestTypes order by TestTypeID";
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
            catch { }
            finally
            {
                connection.Close();
            }
            return dt;

        }

        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees) 
        {
            bool IsUpdated=false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[TestTypes]   SET TestTypeTitle = @TestTypeTitle, TestTypeDescription =@TestTypeDescription ,TestTypeFees = @TestTypeFees WHERE TestTypeID=@TestTypeID";
            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            try
            {
                connection.Open();
                int RowsEffected = cmd.ExecuteNonQuery();
                if (RowsEffected>0)
                {
                    IsUpdated = true;
                }
                else
                {
                    IsUpdated = false;
                }
            }
            catch 
            {
                IsUpdated = false;
            }
            finally { connection.Close(); }
            return IsUpdated;

        }
        public static bool GetTestTypeByID(int TestTypeID,ref string TestTypeTitle, ref string TestTypeDescription, ref float TestTypeFees) 
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = " select * from TestTypes where TestTypeID = @TestTypeID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToSingle (reader["TestTypeFees"]);


                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;

        }

        public static int AddTestType(string TestTypeTitle, string TestTypeDescription, float TestTypeFees) 
        {
            int TestTypeID = -1;

            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = " Insert Into TestTypes (TestTypeTitle,TestTypeDescription,TestTypeFees)" +
                "  Values (@TestTypeTitle,@TestTypeDescription,@TestTypeFees)  " +
                " SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = cmd.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(),out int InsertedID))
                {
                    TestTypeID = InsertedID;

                }

            }
            catch {}
            finally { connection.Close(); }
            return TestTypeID;



        }


    }
}
