using System;
using MyFirstClassLibrary;

namespace DotNet__Class_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMyMath Math =new clsMyMath();
            Console.WriteLine("My sum is "+ Math.sum(1, 3));
            Console.ReadKey();
        }
    }
}
