using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Attributes_Examples
{
    [Serializable]
    public class Employee
    {
        public int EmployeeID;
        [NonSerialized]
        public string Name;
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string Region;
        [NonSerialized]
        public string PostalCode;
        public string Country;
        [NonSerialized]

        public string Phone;
        public string Fax;
        public string FaxNumber;


    }
    class Program
    {
         static void Main(string[] args)
         {
            Employee emp = new Employee
            {
                EmployeeID = 1,
                Name = "Oussama",
                FirstName = "Abdelli",
                LastName = "Ben Kmiti",
                Address = "Mourouj1",
                City = "Ben Arous",
                Region = "Tunisia",
                PostalCode = "2074",
                Country = "Tunisia",
                Phone = "93921970",
                Fax = "Fax1",
                FaxNumber = "FaxNumber1"


            };
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("SerializaionAttributes.xml"))
            {
                serializer.Serialize(writer, emp);
            }

            using(TextReader reader = new StreamReader("SerializaionAttributes.xml"))
            {
                Employee DeserialzedEmployes = (Employee)serializer.Deserialize(reader);
                Console.WriteLine("____________________________________");
                Console.WriteLine(DeserialzedEmployes.EmployeeID);
                Console.WriteLine(DeserialzedEmployes.Name);
                Console.WriteLine(DeserialzedEmployes.LastName);
                Console.WriteLine(DeserialzedEmployes.PostalCode);
                Console.WriteLine(DeserialzedEmployes.Country);
                Console.WriteLine(DeserialzedEmployes.City);
                Console.WriteLine(DeserialzedEmployes.LastName);
                Console.WriteLine(DeserialzedEmployes.FirstName);
                Console.WriteLine(DeserialzedEmployes.Region);

                Console.ReadKey();
            }

        }
    }
}
