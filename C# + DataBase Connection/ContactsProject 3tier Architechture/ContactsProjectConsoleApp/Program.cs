using System;
using System.Data;
using ContactBusinessLayer;

namespace ContactsProjectConsoleApp
{
    internal class Program
    {
        public static void TestFindContactByID(int ID)
        {
          clsContacts Contact1 = clsContacts.Find(ID);
            if (Contact1 != null)
            {
                Console.WriteLine("ContactID=" + Contact1.ID);
                Console.WriteLine("ContactName=" + Contact1.FirstName + " " + Contact1.LastName);
                Console.WriteLine("ContactEamil=" + Contact1.Email);
                Console.WriteLine("ContactPhone=" + Contact1.Phone);
                Console.WriteLine("Contact ImagePATH=" + Contact1.ImagePath);
                Console.WriteLine("Contact CountryID=" + Contact1.CountryID);
                Console.WriteLine("ContactAddress=" + Contact1.Address);

            }
            else
                Console.WriteLine("Contact Not Found");
        }
        static void TestFindCountryByID(int ID)
        {
            clsCountry Country = clsCountry.FindCountryByID(ID);
            if(Country!=null)
            {
                Console.WriteLine("CountryID: " + Country.CountryID);
                Console.WriteLine("CountryName: " + Country.CountryName);
                Console.WriteLine("Code: " + Country.Code);
                Console.WriteLine("PhoneCode: " + Country.PhoneCode);

            }
            else
            {
                Console.WriteLine("Country Not Found ");
            }
        }

        static void TestFindCountryByName(string  CountryName)
        {
            clsCountry Country = clsCountry.FindCountryByName(CountryName);
            if (Country != null)
            {
                Console.WriteLine("CountryID: " + Country.CountryID);
                Console.WriteLine("CountryName: " + Country.CountryName);
            }
            else
            {
                Console.WriteLine("Country Not Found ");
            }
        }



        public static void TestAddNewContact()
        {
            clsContacts Contact2 = new clsContacts();
            Contact2.FirstName = "Oussama";
            Contact2.LastName = "Abdelli";
            Contact2.Email = "Oussama.abdeli@Gmail.com";
            Contact2.Phone = "93921970";
            Contact2.ImagePath = "C:\\My_Images";
            Contact2.CountryID = 1;
            Contact2.Address = "Mourouj 1";
            Contact2.DateOfBirth = DateTime.Now;
            if(Contact2.Save())
            {
                Console.WriteLine("Contact Added Succefully");
            }
        }
        public static void TestAddNewCountry()
        {
            clsCountry Country = new clsCountry();
            Country.CountryName = "Tunisia";
            Country.Code = "1";
            Country.PhoneCode = "3";
            if(Country.Save())
            {
                Console.WriteLine("Country Added Successfuly");
            }
            else
            {
                Console.WriteLine("Failed To Add The New Country ");
            }

        }



        public static void TestUpdateContact(int ID)
        {
            clsContacts Contact2 = clsContacts.Find(ID);
            if(Contact2!=null)
            {
                Contact2.FirstName = "Oussama";
                Contact2.LastName = "Abdelli";
                Contact2.Address = "Mourouj_1";
                Contact2.Phone = "93921970";
                Contact2.Email = "Oussama.abdeli@etudiant.utm.tn";
                Contact2.ImagePath = "";
                Contact2.CountryID = 1;
            }
            if(Contact2.Save())
            {
                Console.WriteLine("Contact2 Saved Succesfully");
            }

        }
        public static void TestUpdateCountry(int ID)
        {
            clsCountry Country =clsCountry.FindCountryByID(ID);
            if(Country!=null)
            {
                Country.CountryName = "Palestine";
                Country.Code = "2";
                Country.PhoneCode = "4";
            }

            if (Country.Save())
            {
                Console.WriteLine("Country Updated Sucessfuly");
            }
            else
                Console.WriteLine("Failed To Update Country  ");

        }

        public static void TestDeleteContact(int ID)
        {
            if (clsContacts.DeleteContact(ID))
            {
                Console.WriteLine("Contact Deleted Successfuly");

            }
            else
                Console.WriteLine("Fail to Delete Contact");
        }

        public static void TestDeleteCountry(int CountryID)
        {
            if (clsCountry.DeleteCountry(CountryID))
            {
                Console.WriteLine("Country Deleted Succesfully");

            }
            else
                Console.WriteLine(" Failed To Delete Country");
        }

        public static void ListContacts()
        {
            DataTable dataTable = clsContacts.GetAllContacts();
            Console.WriteLine("Contacts Data");
            foreach (DataRow Row  in dataTable.Rows )
            {
                Console.WriteLine($"ID{Row["ContactID"]},FirstName{Row["FirstName"]}");
            }
        }

        public static void TestListCountry()
        {
            DataTable dataTable = clsCountry.GetAllCountries();
            Console.WriteLine("Countries Data");
            foreach(DataRow Row in dataTable.Rows)
            {
                Console.WriteLine($"{Row["CountryID"]},{Row["CountryName"]},{Row["Code"]},{Row["PhoneCode"]}");
            }

        }

        public static void TestIsContactExist(int ID)
        {
            if(clsContacts.isContactExist(ID))
            {
                Console.WriteLine("Yes Contact Exist ");
            }
            else
            {
                Console.WriteLine("Contact Does Not Exist ");
            }

        }

        public static void TestIsCountryExist(int CountryID)
        {
            if(clsCountry.isCountryExist(CountryID))
            {
                Console.WriteLine("Yes Country Exist");
            }
            else
                Console.WriteLine("No Country Does Not Exist");
        }


        public static void TestIsCountryExistByName(string CountryName)
        {
            if (clsCountry.isCountryExistByName(CountryName))
            {
                Console.WriteLine("Yes Country Exist");
            }
            else
                Console.WriteLine("No Country Does Not Exist");
        }


        static void Main(string[] args)
        {
            //TestFindContactByID(5);
            //TestAddNewContact();
            //TestUpdateContact(1);
            //TestDeleteContact(8);
            //ListContacts();
            //TestIsContactExist(1);
            //TestFindCountryByID(8);
            //TestFindCountryByName("Palestine");
            //TestAddNewCountry();
            TestUpdateCountry(1);
            //TestDeleteCountry(2);
            //TestListCountry();
            //TestIsCountryExist(1);
            //TestIsCountryExistByName("Tunisia");
            Console.ReadKey();
        }
    }
}
