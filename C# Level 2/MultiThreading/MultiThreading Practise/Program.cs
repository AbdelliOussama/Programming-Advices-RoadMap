using System;
using System.Threading;

namespace MultiThreading_Practise
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            t1.Start();

            Thread t2 = new Thread(Method2);
            t2.Start();


            t1.Join();
            t2.Join();

            void Method2()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("This Is Second Thread Excution");
                    Thread.Sleep(1000); 
                }
            }

            void Method1()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("This Is First Thread Excution");
                    Thread.Sleep(1000);

                }
            }


            for (int i = 0;i<=10;i++)
            {
                Console.WriteLine("This Is The Main Thread Excution");
                Thread.Sleep(1000);

            }

            Console.ReadKey();
        }
    }
}
