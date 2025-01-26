using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string ConnectionString = @"Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";
    static void DeleteContact(int ContactID)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);
        string Query = @"DELETE FROM Contacts WHERE ContactID = @ContactID";
        SqlCommand Command = new SqlCommand(Query, Connection);
        Command.Parameters.AddWithValue("@ContactID", ContactID);
        try
        {
            Connection.Open();
            int AffectedRow = Command.ExecuteNonQuery();
            if (AffectedRow > 0)
            {
                Console.WriteLine("Item Deleted Succesfully");

            }
            else
            {
                Console.WriteLine("Fail To Delete Item");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
    }

    public static void Main()
    {

       
        DeleteContact(7);

        Console.ReadKey();

    }

}
