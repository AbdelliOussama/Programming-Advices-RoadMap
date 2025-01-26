using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace ContactDataAccessLayer
{
    public class clsCountryData
    {
        public static bool GetCountryByID(int CountryID, ref string CountryName,ref string Code,ref string PhoneCode)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * from Countries Where CountryID=@CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    CountryName = (string)Reader["CountryName"];
                    if (Reader["Code"] != DBNull.Value)
                    {
                        Code = (string)Reader["Code"];
                    }
                    else
                    {
                        Code = "";
                    }

                    if (Reader["PhoneCode"] != DBNull.Value)
                    {
                        PhoneCode = (string)Reader["PhoneCode"];
                    }
                    else
                    {
                        PhoneCode = "";
                    }
                    
                    

                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
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
        public static bool GetCountryByName(string CountryName, ref int CountryID,ref string Code,ref string PhoneCode)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * from Countries Where CountryName=@CountryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    CountryID = (int)Reader["CountryID"];
                    if (Reader["Code"] != DBNull.Value)
                    {
                        Code = (string)Reader["Code"];
                    }
                    else
                    {
                        Code = "";
                    }

                    if (Reader["PhoneCode"] != DBNull.Value)
                    {
                        PhoneCode = (string)Reader["PhoneCode"];
                    }
                    else
                    {
                        PhoneCode = "";
                    }


                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
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

        public static int AddNewCountry(string CountryName,string Code,string PhoneCode)
        {
            int CountryID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Countries (CountryName,Code,PhoneCode) Values (@CountryName,@Code,@PhoneCode);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            Command.Parameters.AddWithValue("@Code", Code);
            Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            if (Code != "")
            {
                Command.Parameters.AddWithValue("@Code", Code);
            }
            else
                Command.Parameters.AddWithValue("@Code", DBNull.Value);


            if (PhoneCode != "")
            {
                Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            }
            else
                Command.Parameters.AddWithValue("@PhoneCode", DBNull.Value);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedCountryID))
                {
                    CountryID = InsertedCountryID;
                }
                else
                {
                    return -1;
                }

               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return CountryID;
        }


        public static bool UpdateCountry(int CountryID, string CountryName,string Code,string PhoneCode)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE Countries set 
            CountryName=@CountryName,
            Code=@Code,
            PhoneCode=@Code
            Where CountryID=@CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            if (Code != "")
            {
                Command.Parameters.AddWithValue("@Code", Code);
            }
            else
                Command.Parameters.AddWithValue("@Code", DBNull.Value);


            if (PhoneCode != "")
            {
                Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            }
            else
                Command.Parameters.AddWithValue("@PhoneCode", DBNull.Value);
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return RowsAffected > 0;

        }

        public static bool DeleteCountry(int CountryID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"DELETE FROM Countries WHERE CountryID=@CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
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
            return (RowsAffected > 0);
        }

        public static DataTable GetAllCountries()
        {
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Countries;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    table.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return null;
            }
            finally
            {
                Connection.Close();
            }
            return table;
        }

        public static bool isCountryExist(int CountryID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found=1 from Countries where CountryID=@CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                isFound = Reader.HasRows;
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
            return isFound;
        }


        public static bool isCountryExistByName(string CountryName)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found=1 from Countries where CountryName=@CountryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                isFound = Reader.HasRows;
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
            return isFound;
        }
    }
}
