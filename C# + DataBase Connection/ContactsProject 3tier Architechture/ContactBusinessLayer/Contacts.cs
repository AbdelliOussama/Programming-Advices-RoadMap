using System;
using System.Data;
using System.Deployment.Internal;
using ContactDataAccessLayer;


namespace ContactBusinessLayer
{
    public class clsContacts
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int CountryID { get; set; }
        public DateTime DateOfBirth { get; set; }

        private bool _UpdateContact()
        {
            return clsContacDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.CountryID, this.ImagePath);
        }
        private bool _AddNewContact()
        {
            this.ID = clsContacDataAccess.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.ImagePath, this.CountryID, this.DateOfBirth);
            return (ID!=-1);
        }
        public clsContacts()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.ImagePath = "";
            this.CountryID = -1;
            this.DateOfBirth = DateTime.Now;
        }
        private clsContacts(int iD, string firstName, string lastName, string email, string phone, string address, string imagePath, int countryID, DateTime dateOfBirth)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.ImagePath = imagePath;
            this.CountryID = countryID;
            this.DateOfBirth = dateOfBirth;
            Mode = enMode.Update;
        }
        public static clsContacts Find(int ID)
        {
            string FirstName = "", LastName = "", Address = "", Phone = "", Email = "", ImagëPath = "";
            int CountryID = -1;
            DateTime DateOfBirth = DateTime.Now;
            if (clsContacDataAccess.GetContactInfoByID(ID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagëPath))
            {
                return new clsContacts(ID, FirstName, LastName, Email, Phone, Address, ImagëPath, CountryID, DateOfBirth);

            }
            else return null;

        }
        public  bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    
                        if (_AddNewContact())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;

                case enMode.Update:
                    return _UpdateContact(); 
                    
            }
            return false;
        }

        public static bool DeleteContact(int ID )
        {
            return clsContacDataAccess.DeleteContact(ID);
        }

        public static DataTable GetAllContacts()
        {
            return clsContacDataAccess.GetAllContacts();
        }
        public static bool isContactExist(int ID)
        {
            return clsContacDataAccess.isContactExist(ID);
        }

    }
}
