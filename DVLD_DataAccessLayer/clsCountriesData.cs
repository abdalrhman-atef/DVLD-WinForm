using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_DataAccessLayer
{
    public class clsCountriesData
    {
        public static bool GetCountryInfoByName(string CountryName, ref int CountryID)
        {
            bool IsFound = false;
            CountryID = -1;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM [dbo].[Countries] where CountryName=@CountryName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CountryID = (int)reader["CountryID"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());


            }
            finally
            {
                connection.Close();

            }
            return IsFound;


        }
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {
            CountryName = "";
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM [dbo].[Countries] where CountryID=@CountryID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    CountryName = (string)reader["CountryName"];


                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());


            }
            finally
            {
                connection.Close();

            }
            return IsFound;

        }
        public static DataTable GetAllCountries()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDVLD_DataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM [dbo].[Countries] ";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
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
            return dataTable;

        }


    }
}
