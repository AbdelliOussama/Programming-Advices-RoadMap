using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilder_Practise
{
    internal class Program
    {
        public static void InsertOnString(int Iterations)
        {
            string ListNumbers = "";
            for(int i=0;i<=Iterations;i++)
            {
                ListNumbers += i.ToString();
            }
            Console.WriteLine(ListNumbers);
        }

        public static void InsertOnStringWithStringBuilder(int Iterations)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0;i<=Iterations; i++)
            {
                stringBuilder.Append(i.ToString());
            }
            Console.WriteLine(stringBuilder.ToString());
        }
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew(); 
            InsertOnString(100000000);
            sw.Stop();
            Console.WriteLine("The Time Needed To Dill With This Operation Was : "+ sw.ElapsedMilliseconds +"(ms)");


            Stopwatch sw1 = Stopwatch.StartNew();
            InsertOnStringWithStringBuilder(100000000);
            sw1.Stop();
            Console.WriteLine("The Time Needed To Dill With This Operation Was : " + sw1.ElapsedMilliseconds + "(ms)");


            Console.ReadKey();
        }
    }
}
