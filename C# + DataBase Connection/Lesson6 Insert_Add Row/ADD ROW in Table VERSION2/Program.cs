using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;


namespace ADD_ROW_in_Table_VERSION2
{
    internal class Program
    {
        static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";

        public struct stContact
        {
            public string FirstName  { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }   
            public string Address { get; set; }
            public int CountryID { get; set; }

        }

        static void AddNewRecord(stContact Contact)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID)       VALUES(@FirstName,@LastName,@Eamil,@Phone,@Address,@CountryID)";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            Command.Parameters.AddWithValue("@LastName", Contact.LastName);
            Command.Parameters.AddWithValue("@Email", Contact.Email);
            Command.Parameters.AddWithValue("@Phone", Contact.Phone);
            Command.Parameters.AddWithValue("@Address", Contact.Address);
            Command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

            try
            {
                Connection.Open();
                int NumberOfRowAffected = Command.ExecuteNonQuery();
                if (NumberOfRowAffected > 0)
                {
                    Console.WriteLine("Row Added Succesfully");
                }
                else
                {
                    Console.WriteLine("Row Add Failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            stContact Contact = new stContact
            {
                FirstName = "Oussama",
                LastName = "Abdelli",
                Email = "Oussama.Abdelli@Yahoo.fr",
                Phone = "123456",
                Address = "Mourouj1",
                CountryID = 1

            };

            AddNewRecord(Contact);
            Console.ReadKey();


        }
    }
}
