using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        static string Connectionstring = "server=.;Database=HR_Database;User=sa;Password=sa123456";

        static void Retrieve_DataFromHR()
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);

            string Query = "select top 10 Employees.ID,Employees.FirstName,Employees.LastName,Employees.Gendor,DATEDIFF(Year,Employees.DateOfBirth,GetDate()) as Age, Countries.Name as ContryName from\r\nEmployees join Countries on Employees.CountryID=Countries.ID order by Age";

            SqlCommand command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) 
                {
                    int ID = (int)reader["ID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Gendor = (string)reader["Gendor"];
                    int AGE = (int)reader["Age"];
                    string ContryName = (string)reader["ContryName"];
                    Console.WriteLine("***************************************");
                    Console.WriteLine($"Employee ID: {ID}");
                    Console.WriteLine($"FirstName: {FirstName}");
                    Console.WriteLine($"LastName: {LastName}");
                    Console.WriteLine($"Employee Gendor: {Gendor}");
                    Console.WriteLine($"Employee Age: {AGE}");
                    Console.WriteLine($"Employee Contry: {ContryName}");
                    Console.WriteLine("***************************************");






                }
                reader.Close();
                Connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            
        }

        static void Main(string[] args)
        {
            Retrieve_DataFromHR();
            Console.ReadKey();
        }
    }
}
