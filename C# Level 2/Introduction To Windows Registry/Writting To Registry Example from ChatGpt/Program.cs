using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writting_To_Registry_Example_from_ChatGpt
{

    class Program
    {
        static void Main()
        {
            try
            {
                // Create or open a subkey
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\MyApp");

                if (key != null)
                {
                    // Set a value in the subkey
                    key.SetValue("MySetting", "Hello, World!");

                    Console.WriteLine("Value written to registry.");

                    // Close the key
                    key.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Error Has Occured : "+ ex.Message);
            }
            Console.ReadKey();
        }
    }

}

