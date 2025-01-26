using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;

namespace RetrievAutoNumber_after_Adding
{
    internal class Program
    {
        static string ConnectionString = @"Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";

        public struct stContact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }

        }
        static void AddNewContactandRetrieveAutoNumber(stContact Contact)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "insert into Contacts (FirstName,LastName,Email,Phone,Address,CountryID) values (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID);select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            Command.Parameters.AddWithValue("@LastName", Contact.LastName);
            Command.Parameters.AddWithValue("@Email", Contact.Email);
            Command.Parameters.AddWithValue("@Phone", Contact.Phone);
            Command.Parameters.AddWithValue("@Address", Contact.Address);
            Command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int interestedID))
                {
                    Console.WriteLine($"Inserted Id is {interestedID}");
                }
                else
                {
                    Console.WriteLine("Failed To returnID");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
             
            

        }
        static void Main(string[] args)
        {
            stContact Contatc1 = new stContact
            {
                FirstName = "Salim",
                LastName = "Abdelli",
                Email = "Salimab99@gmail.com",
                Phone = "33746374",
                Address = "Reims",
                CountryID = 4
            };
            AddNewContactandRetrieveAutoNumber(Contatc1);
            Console.ReadKey();
        }
    }
}
