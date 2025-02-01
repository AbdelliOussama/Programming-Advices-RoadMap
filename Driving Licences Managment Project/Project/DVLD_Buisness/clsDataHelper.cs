using System;
using System.Security.Cryptography;
using System.Text;

namespace DVLD_Buisness
{
    public class clsDataHelper
    {
        public static string ComputeHash(string Data)
        {
            using(SHA256 sha256= SHA256.Create())
            {
                byte[] shaBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Data));
                return BitConverter.ToString(shaBytes).Replace("-", "").ToLower();
            }
        }
    }
}
