using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate_Example2
{
    internal class Program
    {

        static Predicate<string> IWorkOrNot = Work;

        public static bool Work(string Responce)
        {
            return Responce == "They Change Timing" ? true : false;
        }
        static void Main(string[] args)
        {
            bool DoIwork = IWorkOrNot("They Change Timing");
            Console.WriteLine(DoIwork);
            Console.ReadKey();
        }
    }
}
