using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using Microsoft.Win32;


namespace DVLD.Classes
{
    internal static  class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            //try
            //{
            //    //this will get the current project directory folder.
            //    string currentDirectory = System.IO.Directory.GetCurrentDirectory();


            //    // Define the path to the text file where you want to save the data
            //    string filePath = currentDirectory + "\\data.txt";

            //    //incase the username is empty, delete the file
            //    if (Username=="" && File.Exists(filePath)) 
            //    { 
            //         File.Delete(filePath);
            //        return true;

            //    }

            //    // concatonate username and passwrod withe seperator.
            //    string dataToSave = Username + "#//#"+Password ;

            //    // Create a StreamWriter to write to the file
            //    using (StreamWriter writer = new StreamWriter(filePath))
            //    {
            //        // Write the data to the file
            //        writer.WriteLine(dataToSave);

            //      return true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //   MessageBox.Show ($"An error occurred: {ex.Message}");
            //    return false;
            //}

            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_APP";
            string ValueName1 = "UserName";
            string ValueName2 = "PassWord";
            string ValueData1 = Username;
            string ValueData2 = Password; 
            try
            {
                Registry.SetValue(KeyPath, ValueName1, ValueData1);
                Registry.SetValue(KeyPath, ValueName2, ValueData2);
            }
            catch(Exception ex )
            {
                Console.WriteLine("An Error Has Occured : "+ex.Message);
                return false;
            }
            return true;
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            ////this will get the stored username and password and will return true if found and false if not found.
            //try
            //{
            //    //gets the current project's directory
            //    string currentDirectory = System.IO.Directory.GetCurrentDirectory();

            //    // Path for the file that contains the credential.
            //    string filePath  = currentDirectory + "\\data.txt";

            //    // Check if the file exists before attempting to read it
            //    if (File.Exists(filePath))
            //    {
            //        // Create a StreamReader to read from the file
            //        using (StreamReader reader = new StreamReader(filePath))
            //        {
            //            // Read data line by line until the end of the file
            //            string line;
            //            while ((line = reader.ReadLine()) != null)
            //            {
            //                Console.WriteLine(line); // Output each line of data to the console
            //                string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            //                Username = result[0];
            //                Password = result[1];
            //            }
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show ($"An Error occurred: {ex.Message}");
            //    return false;   
            //}

            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_APP";
            string ValueName1 = "UserName";
            string ValueName2 = "PassWord";
            try
            {
                Username = Registry.GetValue(KeyPath, ValueName1, null) as string;
                Password = Registry.GetValue(KeyPath, ValueName2, null) as string;
                if(Username != null && Password != null)
                    { return true; }
                else
                    return false;
            }
            catch (Exception ex )
            {
                Console.WriteLine("An Error Has Occured "+ex.Message);
                return false;
            }
            return true ;


        }
    }
}
