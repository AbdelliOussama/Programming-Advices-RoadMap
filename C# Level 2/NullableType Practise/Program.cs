using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType_Practise
{
    internal class Program
    {

        public static void Procedure1(string name,DateTime? Age,int? NumberOfCars,float?Salary)
        {
            Console.WriteLine("This Is My Personal Card :");
            Console.WriteLine("______________________________________");
            Console.WriteLine(name);
            Console.WriteLine(Age?.ToShortDateString());
            if(NumberOfCars.HasValue)
            {
                Console.WriteLine(NumberOfCars.ToString());
            }
            else
                Console.WriteLine("You Dont Have Cars Nchalah Rabi Ysahel Alik");
            if(Salary.HasValue)
            {
                Console.WriteLine(Salary.ToString());
            }
            else
                Console.WriteLine("Nchalah Rabi Yjib el Gasm ):");

        }
        static void Main(string[] args)
        {
            //    Nullable<DateTime>DetainDate = DateTime.Now;
            //    if(DetainDate.HasValue)
            //    {
            //        Console.WriteLine(DetainDate.Value);
            //    }

            //    DateTime?dt = DateTime.Now;
            //    string DateString =dt?.ToString();
            //
            Procedure1("Oussama", null, null, null);
            Procedure1("Oussama",DateTime.Now, null, null);
            Procedure1("Oussama", DateTime.Now,1, null);
            Console.ReadKey();

        }
    }
}
