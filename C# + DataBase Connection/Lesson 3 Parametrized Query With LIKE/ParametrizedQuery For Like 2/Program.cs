using System;
using  System.Net;
using System.Data;
using System.Data.SqlClient;

namespace ParametrizedQuery_For_Like_2
{
    internal class Program
    {
       static string ConnectionString = "Server=.;Database=ContactsDB;User=sa;Password=sa123456;";

        static void RetrieveCountriesSatrtWith(string StartsWith)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Countries where CountryName Like ''+@StartsWith +'%'";
            SqlCommand Command=new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@StartsWith", StartsWith);
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    int CountryID = (int)reader["CountryID"];
                    string CountryName = (string)reader["CountryName"];

                    Console.WriteLine($"CountryID :\t{CountryID}");
                    Console.WriteLine($"CountryName:\t{CountryName}");

                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            


        }
        
        static void Main(string[] args)
        {
            RetrieveCountriesSatrtWith("Un");
            Console.ReadKey();
        }
    }
}
