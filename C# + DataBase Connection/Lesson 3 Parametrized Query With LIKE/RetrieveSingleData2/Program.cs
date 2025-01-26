using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;

namespace RetrieveSingleData2
{
    internal class Program
    {
        static string ConnectionString = "Server=.;Database=HR_Database;User Id=sa;Password=sa123456;";
        static string RetrieveFirstName(int ID)
        {
            string FirstName="";
            SqlConnection Connection =new SqlConnection(ConnectionString);
            string Query = "select FirstName from Employees where ID =@ID";
            SqlCommand Command =new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null) 
                {
                    FirstName = Result.ToString();
                }
                else
                {
                    FirstName = "";
                }

                Connection.Close();
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            return FirstName;
        }
        static void Main(string[] args)
        {
            RetrieveFirstName(285);
            Console.ReadKey();
        }
    }
}
