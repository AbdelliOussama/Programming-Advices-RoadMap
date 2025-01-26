using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Application3_Mixed_Parametrized_Query
{
    
    internal class Program
    {
        static string ConnectionString = "Server=.;Database=VehiculeMakers;User=sa;Password=sa123456;";

        static void RetrieveDataStartsWith(string StartsWith)
        {
            SqlConnection Connection =new SqlConnection(ConnectionString);
            string Query= "select top 10 ID, Vehicle_Display_Name,Engine_CC,Engine_Cylinders,NumDoors from VehicleDetails where Vehicle_Display_Name like ''+@StartsWith+'%' ";
            SqlCommand Command=new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@StartsWith", StartsWith);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ID = (int)Reader["ID"];
                    string Vehicle_Display_Name = (string)Reader["Vehicle_Display_Name"];
                    int Engine_CC = (int)Reader["Engine_CC"];
                    int Engine_Cylinders = (int)Reader["Engine_Cylinders"];
                    int NumDoors = (int)Reader["NumDoors"];
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine($"VehicleID is {ID}");
                    Console.WriteLine($"Vehicle_Display_Name is {Vehicle_Display_Name}");
                    Console.WriteLine($"VehicEngineCC is {Engine_CC}");
                    Console.WriteLine($"Vehicle Engine_Cylinders is {Engine_Cylinders}");
                    Console.WriteLine($"Vehicle Number Of Doors is {NumDoors}");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");

                }
                Reader.Close();
                Connection.Close();

                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void RetriveDataWhereYearEqual(int Year)
        {
            SqlConnection Connection2 = new SqlConnection(ConnectionString);
            string Query = "select top 10 ID, Vehicle_Display_Name,Year,Engine_CC,Engine_Cylinders,NumDoors from VehicleDetails where Year=@Year ";
            SqlCommand Command2 = new SqlCommand(Query, Connection2);
            Command2.Parameters.AddWithValue("@Year", Year);



            try
            {
                Connection2.Open();
                SqlDataReader Reader2 = Command2.ExecuteReader();

                while (Reader2.Read())
                {
                    int ID = (int)Reader2["ID"];
                    string Vehicle_Display_Name = (string)Reader2["Vehicle_Display_Name"];
                    int year = (int)Reader2["Year"];
                    int Engine_CC = (int)Reader2["Engine_CC"];
                    int Engine_Cylinders = (int)Reader2["Engine_Cylinders"];
                    int NumDoors = (int)Reader2["NumDoors"];
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine($"VehicleID is {ID}");
                    Console.WriteLine($"Vehicle_Display_Name is {Vehicle_Display_Name}");
                    Console.WriteLine($"Vehicle MakeYear is {Year}");
                    Console.WriteLine($"VehicEngineCC is {Engine_CC}");
                    Console.WriteLine($"Vehicle Engine_Cylinders is {Engine_Cylinders}");
                    Console.WriteLine($"Vehicle Number Of Doors is {NumDoors}");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");

                }
                Reader2.Close();
                Connection2.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            RetrieveDataStartsWith("BMW");
            //RetriveDataWhereYearEqual(1995);
            Console.ReadKey();
        }
    }
}
