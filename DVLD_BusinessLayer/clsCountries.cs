using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsCountries
    {
        public int _CountryID { get; set; }
        public string _CountryName { get; set; }
        public clsCountries() 
        {
        this._CountryID = 0;
            this._CountryName = "";



        }
        private clsCountries(int CountryID,string CountryName)
        {
            this._CountryName=CountryName;
            this._CountryID = CountryID;


        }

        public static clsCountries FindCountry(string CountryName)
        {

            int countryID = -1;
            if (clsCountriesData.GetCountryInfoByName(CountryName, ref countryID))
            {
                return new clsCountries(countryID,CountryName);
            }
            else
            {
                return null;
            }




        }
        public static clsCountries FindCountry(int CountryID)
        {
            string CountryName = "";
            if (clsCountriesData.GetCountryInfoByID(CountryID,ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }

        }
        public static DataTable GetAllCountries()
        {
           
            return clsCountriesData.GetAllCountries(); ;



        }
    }
}
