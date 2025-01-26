using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace EmpDataAccess
{
    public class clsEmpData
    {
        public static string ConnectionString = "Server =.;Database = C21_DB1; User Id = sa;Password = sa123456 ;";
        public static DataTable GetAllEmployee()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employees2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            return dt;
        }

      
    }
}
