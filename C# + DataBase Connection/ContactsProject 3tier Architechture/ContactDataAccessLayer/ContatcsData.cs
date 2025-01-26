using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;



namespace ContactDataAccessLayer
{
    public class clsContacDataAccess
    {
         public static bool GetContactInfoByID( int ID,ref string FirstName,ref string LastName,ref string Email,ref string Phone ,ref string Address,ref DateTime DateOfBirth,ref int CountryID,ref string ImagePath)
         {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Contacts where ContactID=@ContactID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    Address = (string)Reader["Address"];
                    CountryID = (int)Reader["CountryID"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
         }

        public static int AddNewContact(string FirstName,string LastName,string Email,string Phone ,string Address,string ImagePath,int CountryID,DateTime DateOfBirth)
        {
            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Contacts(FirstName,LastName,Email,Phone,Address,ImagePath,CountryID,DateOfBirth) 
            VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@ImagePath,@CountryID,@DateOfBirth;
            SELECT SCOPE_IDENTITY();" ;

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone",Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (ImagePath!="")
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ContactID= InsertedID;

                }
                else
                    return -1;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return ContactID;

        }

        public static bool UpdateContact(int ID, string FirstName, string LastName, string Email, string Phone, string Address, int CountryID, string ImagePath)
        {
            int AffectedRows = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Contacts  set  FirstName=@FirstName ,LastName=@LastName,Email=@Email,Phone=@Phone,Address=@Address,CountryID=@CountryID,ImagePath=@ImagePath
              WHERE ContactID=@ID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@ID", ID);
            if (ImagePath != "")
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            try
            {
                Connection.Open();
                AffectedRows = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }


            return (AffectedRows > 0);
        }

        public static bool DeleteContact(int ContactID)
        {
            int AffectedRow = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Qurey = @"DELETE FROM Contacts WHERE ContactID=@ContactID;";
            SqlCommand Command = new SqlCommand(Qurey, Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);
            try
            {
                Connection.Open();
                AffectedRow = Command.ExecuteNonQuery();    
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (AffectedRow > 0);
        }
            
        public static DataTable GetAllContacts()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from Contacts;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message); return null;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool isContactExist(int ContactID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT Found=1 from Contacts where ContactID=@ContactID;";
            SqlCommand command =new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                isFound = Reader.HasRows;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

    }

   
}
