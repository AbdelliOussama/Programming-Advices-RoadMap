using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;


namespace Find_One_Contact_Version2
{
    

    internal class Program
    {
        static string ConnectionString = "Server=.;DataBase=ContactsDB;User Id=sa;Password=sa123456;";
        static bool FindContactByID(int ContactID, ref stContact Contact)
        {
            bool isFound=false;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts Where ContactID=@ContactID";
            SqlCommand Command =new SqlCommand (Query,Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.Read())
                {
                    isFound = true;
                    Contact.ContactID=(int) Reader["ContactID"];
                    Contact.FirstName = (string)Reader["FirstName"];
                    Contact.LastName = (string)Reader["LastName"];
                    Contact.LastName = (string)Reader["LastName"];
                    Contact.Email= (string)Reader["Email"];
                    Contact.Phone = (string)Reader["Phone"];
                    Contact.Address = (string)Reader["Address"];
                    Contact.CountryID = (int)Reader["CountryID"];

                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
                Connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return isFound;
            


        }
        static void AddNewContact(stContact Contact)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID) VALUES(@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";
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
                int NumberOfAffectedRow = Command.ExecuteNonQuery();
                if (NumberOfAffectedRow > 0)
                {
                    Console.WriteLine("Contact Added Succesfully");

                }
                else
                {
                    Console.WriteLine("Contact Add Failed");
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public struct stContact
        {
            public int ContactID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
            
        }
        static void Main(string[] args)
        {
            stContact Contact1 = new stContact
            {
                FirstName = "Oussama",
                LastName ="Andelli",
                Email="Oussama.Abdelli@Yahoo.tn",
                Phone="123456",
                Address="Mourouj1",
                CountryID=1
            };
            AddNewContact(Contact1);



            stContact Contact = new stContact();
            if (FindContactByID(1, ref Contact))
            {
                Console.WriteLine($"ContactID={Contact.ContactID}");
                Console.WriteLine($"ContactFirstName={Contact.FirstName}");
                Console.WriteLine($"ContactLastName={Contact.LastName}");
                Console.WriteLine($"ContactEmail={Contact.Email}");
                Console.WriteLine($"ContactPhone={Contact.Phone}");
                Console.WriteLine($"ContactAddress={Contact.Address}");
                Console.WriteLine($"ContactCountryID={Contact.CountryID}");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
            Console.ReadKey();

           
        }
    }
}

