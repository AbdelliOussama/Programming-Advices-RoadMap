using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList_Tasks_And_Exmples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a LinkedList
            LinkedList<string> names = new LinkedList<string>();

            // Adding elements
            names.AddLast("Alice");
            names.AddLast("Bob");
            names.AddFirst("Eve");

            // Traversing the list
            Console.WriteLine("Names in the LinkedList:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Adding before and after
            var bobNode = names.Find("Bob");
            if (bobNode != null)
            {
                names.AddBefore(bobNode, "Charlie");
                names.AddAfter(bobNode, "David");
            }

            // Removing elements
            names.Remove("Alice");
            names.RemoveLast();

            Console.WriteLine("\nAfter modifications:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Using LINQ
            var filteredNames = names.Where(n => n.Contains("e"));
            Console.WriteLine("\nNames containing 'e':");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }


            /*
            Basic CRUD Operations:

            Create a LinkedList<int> and perform Add, Remove, and Update operations.
            Traverse and display the elements.
            */
            LinkedList<string> familylist = new LinkedList<string>();
            familylist.AddFirst("Baba");
            familylist.AddFirst("Mama");
            familylist.AddLast("Anas");

            foreach(var memebr in familylist)
            {
                Console.WriteLine(memebr);
            }

            var BabaNode = familylist.Find("Baba");
            familylist.AddAfter(BabaNode, "Sarra");
            familylist.AddBefore(BabaNode, "Oussama");

            foreach (var memebr in familylist)
            {
                Console.WriteLine(memebr);
            }

            familylist.Remove("Oussama");
            foreach (var memebr in familylist)
            {
                Console.WriteLine(memebr);
            }
            familylist.Clear();
            foreach (var memebr in familylist)
            {
                Console.WriteLine(memebr);
            }
            /*
            Reversal:
            Write a function to reverse a LinkedList.
            */
            LinkedList<int>Numbers = new LinkedList<int>();
            Numbers.AddLast(0);
            Numbers.AddLast(1);
            Numbers.AddLast(2);
            Numbers.AddLast(3);
            Numbers.AddLast(4);
            foreach (var number in Numbers)
            {
                Console.WriteLine("Number : "+number);
            }

            var ReversedNumber = Numbers.Reverse();
            foreach (var number in ReversedNumber)
            {
                Console.WriteLine("Number : " + number);
            }
            /*
            Find Middle Node:
            Implement a method to find the middle element in a LinkedList.
            */


            /*
            Circular LinkedList Simulation:
            Use a LinkedList to simulate a circular list where the last node links back to the first node.
            */


            /*
            Custom Objects:
            Create a LinkedList<Employee> where Employee has properties like Name and Salary.
            Use LINQ to filter employees with salaries above a threshold.
            */



            /*
            Palindrome Check:
            Write a function to check if a LinkedList<char> forms a palindrome.
            */





            Console.ReadKey();
        }
    }
}
