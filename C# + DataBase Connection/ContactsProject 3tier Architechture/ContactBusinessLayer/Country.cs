using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ContactDataAccessLayer;
using System.Runtime.CompilerServices;

namespace ContactBusinessLayer
{
    public class clsCountry
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode Mode = enMode.AddNew;
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string Code { set; get; }
        public string PhoneCode {  set; get; }
        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
            Code = "";
            PhoneCode="";

        }
        private clsCountry(int countryID, string countryName,string Code,string PhoneCode)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
            this.Code = Code;
            this.PhoneCode=PhoneCode;
            Mode = enMode.Update;
        }
        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryData.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);
            return (CountryID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(this.CountryID, this.CountryName,this.Code,this.PhoneCode);
        }
        public static clsCountry FindCountryByID(int ID)
        {
            string CountryID = "",Code="",PhoneCode="";
           
            if (clsCountryData.GetCountryByID(ID, ref CountryID,ref Code,ref PhoneCode ))
            {
                return new clsCountry(ID, CountryID,Code,PhoneCode);
            }
            else
                return null;
        }

        public static clsCountry FindCountryByName(string CountryName)
        {
            int CountryID = -1;
            string Code = "", PhoneCode = "";
            if (clsCountryData.GetCountryByName(CountryName, ref CountryID,ref Code,ref PhoneCode ))
            {
                return new clsCountry(CountryID, CountryName,Code,PhoneCode);
            }
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }

        public static bool DeleteCountry(int ID)
        {
            return clsCountryData.DeleteCountry(ID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

        public static bool isCountryExist(int CountryID)
        {
            return clsCountryData.isCountryExist(CountryID);
        }


        public static bool isCountryExistByName(string CountryName)
        {
            return clsCountryData.isCountryExistByName(CountryName);
        }
    }


}
