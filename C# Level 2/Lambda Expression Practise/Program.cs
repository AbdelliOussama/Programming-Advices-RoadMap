using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lambda_Expression_Practise
{
    internal class Program
    {

        public delegate void SayHello(string message);

        public static void Calculate(double x,double y,Func<double ,double ,double>Calcul)
        { 
            double Result = Calcul(x,y);
            Console.WriteLine("The Result Is  "+Result );
        }

        static void Main(string[] args)
        {
            //SayHello hello = name => Console.WriteLine($"Hello {name}");
            //hello("oussama");
            //Console.ReadKey();
            Func<double, double, double> Add =(x,y)=>x+y;
            Calculate(4, 6, Add);
            Console.ReadKey();
        }
    }
}
