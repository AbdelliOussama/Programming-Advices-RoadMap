using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate_More_Practise
{
    internal class Program
    {

        public static Func<int, int,float> AVG = Average;
        
        static float Average(int a,int b)
        {
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {
            float A = AVG(5, 6);
            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
