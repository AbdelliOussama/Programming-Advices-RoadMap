using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_From_Registry_ChatGpt_Example
{
    using Microsoft.Win32;

    class Program
    {
        static void Main()
        {
            // Open the subkey of the registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\MyApp");

            if (key != null)
            {
                // Read a value from the subkey
                object value = key.GetValue("MySetting");
                if (value != null)
                {
                    Console.WriteLine("Value: " + value.ToString());
                }
                else
                {
                    Console.WriteLine("Value not found.");
                }

                // Close the key after use
                key.Close();
            }
            else
            {
                Console.WriteLine("Subkey not found.");
            }
        }
    }

}
