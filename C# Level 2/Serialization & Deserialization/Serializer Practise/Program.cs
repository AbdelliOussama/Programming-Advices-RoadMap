using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Serializer_Practise
{

    [Serializable]
    public class Athlete
    {
        public string Name;
        public int Age;
        public DateTime DateOfBirth;
        public double Wheight;
        public string History;

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete();
            athlete.Name = "Oussama";
            athlete.Age = 25;
            athlete.DateOfBirth = new DateTime(11 / 10 / 1999);
            athlete.Wheight = 63.5;
            athlete.History = "3 Time Vise Champion of Tunisia";


            XmlSerializer serializer  = new XmlSerializer(typeof(Athlete));

            using (TextWriter writer = new StreamWriter("Athlete.xml"))
            {
                serializer.Serialize(writer, athlete);
            }

            using(TextReader reader = new StreamReader("Athlete.xml"))
            {
                Athlete DeserilaizedAthlete = (Athlete)serializer.Deserialize(reader);
                Console.WriteLine(DeserilaizedAthlete.Name);
                Console.WriteLine(DeserilaizedAthlete.Age);
                Console.WriteLine(DeserilaizedAthlete.DateOfBirth);
                Console.WriteLine(DeserilaizedAthlete.Wheight);
                Console.WriteLine(DeserilaizedAthlete.History);




                Console.ReadKey();

            }
        }
    }
}
