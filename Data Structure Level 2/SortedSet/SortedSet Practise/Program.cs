using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SortedSet_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            basic Operations:

            Create a SortedSet<int> to store unique student IDs.
            Add some IDs, remove a few, and display all IDs in sorted order.

            */

            SortedSet<int>Students = new SortedSet<int>();
            Students.Add(1);
            Students.Add(20);
            Students.Add(3);
            Students.Add(48);
            Students.Add(5);
            Students.Add(16);
            Students.Add(73);
            Students.Add(84);
            Students.Add(9);

            foreach (int i in Students)
            {
                Console.WriteLine($"Student ID {i}");
            }
            Students.Remove(84);
            Console.WriteLine("Students After Remove Student 84");
            foreach (int i in Students)
            {
                Console.WriteLine($"Student ID {i}");
            }

            /*
            Duplicate Prevention:
            Create a SortedSet<string> to store unique city names.
            Try adding duplicate names and verify they aren't added.
            */

            SortedSet<string>Cities = new SortedSet<string>();
            Cities.Add("Tunis");
            Cities.Add("Ben Arous");
            Cities.Add("Manouba");
            Cities.Add("Ariana");
            Cities.Add("Tunis");

            foreach(string city in Cities)
            {
                Console.WriteLine("City Name : "+city);
            }

            /*
            Set Operations:
            Create two SortedSet<int> objects representing two groups of students.
            Use UnionWith, IntersectWith, and ExceptWith to demonstrate set operations.
            */
            SortedSet<int> Students1 = new SortedSet<int>();
            Students1.Add(1);
            Students1.Add(20);
            Students1.Add(3);
            Students1.Add(48);
            Students1.Add(5);
            Students1.Add(16);
            Students1.Add(73);
            Students1.Add(84);
            Students1.Add(9);
            Console.WriteLine("Student From The First List");
            foreach(int studentID in Students1)
            {
                Console.WriteLine("StudentID : "+studentID);
            }
            SortedSet<int> Students2 = new SortedSet<int>();
            Students2.Add(10);
            Students2.Add(20);
            Students2.Add(31);
            Students2.Add(4);
            Students2.Add(50);
            Students2.Add(16);
            Students2.Add(703);
            Students2.Add(8);
            Students2.Add(93);
            Console.WriteLine("Student From The Second List");
            foreach (int studentID in Students2)
            {
                Console.WriteLine("StudentID : " + studentID);
            }


            SortedSet<int>UnionOfStudents = new SortedSet<int>(Students1);
            UnionOfStudents.Union(Students2);
            Console.WriteLine("Student From The Unions ");
            foreach (int studentID in UnionOfStudents)
            {
                Console.WriteLine("StudentID : " + studentID);
            }

            SortedSet<int>IntersectedStudents = new SortedSet<int>(Students1);
            IntersectedStudents.IntersectWith(Students2);
            foreach (int studentID in IntersectedStudents)
            {
                Console.WriteLine("StudentID : " + studentID);
            }

            SortedSet<int>ExecptStudents = new SortedSet<int>(Students1);
            IntersectedStudents.Except(Students2);
            foreach (int studentID in ExecptStudents)
            {
                Console.WriteLine("StudentID : " + studentID);
            }


            SortedSet<int> SymmetricExceptStudents = new SortedSet<int>(Students1);
            IntersectedStudents.SymmetricExceptWith(Students2);
            foreach (int studentID in SymmetricExceptStudents)
            {
                Console.WriteLine("StudentID : " + studentID);
            }
            /*
            Subset and Superset:
            Create two SortedSet<string> objects with overlapping elements.
            Check if one set is a subset or superset of the other.
            */
            SortedSet<int> Students3 = new SortedSet<int>();
            Students3.Add(1);
            Students3.Add(20);
            Students3.Add(3);
            Students3.Add(48);
            Students3.Add(5);
            Students3.Add(16);
            Students3.Add(73);
            Students3.Add(84);
            Students3.Add(9);
            Console.WriteLine("Student From The First List");
            foreach (int studentID in Students1)
            {
                Console.WriteLine("StudentID : " + studentID);
            }
            SortedSet<int> Students4 = new SortedSet<int>();
            Students2.Add(5);
            Students2.Add(16);
            Students2.Add(31);
            Students2.Add(9);
            
            Console.WriteLine("Student From The Second List");
            foreach (int studentID in Students2)
            {
                Console.WriteLine("StudentID : " + studentID);
            }

            var IsSuperset = Students3.IsSupersetOf(Students4);   
            Console.WriteLine("Student 3 is SuperSet of Student 4"+IsSuperset.ToString());

            var isSubset = Students3.IsSubsetOf(Students4);
            Console.WriteLine("Student 3 is SubSet of Student 4" + isSubset.ToString());


            var IsEqual = Students3.SetEquals(Students4);
            Console.WriteLine("Student 3 is Equal To  Student 4" + IsEqual.ToString());

            /*
            Filtering with LINQ:
            Create a SortedSet<int> of random numbers.
            Use LINQ to retrieve numbers greater than a specific value.
            */
            Console.WriteLine("__________________________________\n");
            SortedSet<int>RandomSortedSet = new SortedSet<int>();   
            Random rand = new Random();
            for (int i = 0;i<=50;i++)
            {
                RandomSortedSet.Add(rand.Next(1,51));
            }
            Console.WriteLine("Random SOrtedSet Number  : "+string.Join(",",RandomSortedSet));


            Console.WriteLine("__________________________________\n");

            var RandomNumberGreaterThan20 = RandomSortedSet.Where(x => x > 20);
            Console.WriteLine("Random  Number > 20 : " + string.Join(",", RandomNumberGreaterThan20));


            /*
            Custom Sorting:
            Create a SortedSet of custom objects(e.g., Employee with properties Name, Age, and Salary).
            Implement a custom comparer using IComparer to sort by salary.
            */

            /*
            Range Queries:

            Use LINQ to find the smallest and largest elements in a SortedSet<int>.
            Retrieve elements within a specific range(e.g., between 10 and 50).
            */
            SortedSet<int> Numbers = new SortedSet<int>();
            Numbers.Add(10);
            Numbers.Add(20);
            Numbers.Add(31);
            Numbers.Add(4);
            Numbers.Add(50);
            Numbers.Add(16);
            Numbers.Add(703);
            Numbers.Add(8);
            Numbers.Add(93);

            foreach(int Number in Numbers)
            {
                Console.WriteLine("Number : "+Number);
            }

            var Minimum = Numbers.Min();
            var Maximum = Numbers.Max();    
            var AVerage = Numbers.Average();
            Console.WriteLine($" The Minimum is {Minimum} The Max is {Maximum} The Average  = {AVerage} ");
            /*
            Merging and Comparing:

            Create two SortedSet<int> objects with overlapping and unique elements.
            Merge them and find elements exclusive to each set.
            */
            SortedSet<int> Students1 = new SortedSet<int>();
            Students1.Add(1);
            Students1.Add(20);
            Students1.Add(3);
            Students1.Add(48);
            Students1.Add(5);
            Students1.Add(16);
            Students1.Add(73);
            Students1.Add(84);
            Students1.Add(9);
            Console.WriteLine("Student From The First List");
            foreach (int studentID in Students1)
            {
                Console.WriteLine("StudentID : " + studentID);
            }
            SortedSet<int> Students2 = new SortedSet<int>();
            Students2.Add(10);
            Students2.Add(20);
            Students2.Add(31);
            Students2.Add(4);
            Students2.Add(50);
            Students2.Add(16);
            Students2.Add(703);
            Students2.Add(8);
            Students2.Add(93);
            Console.WriteLine("Student From The Second List");
            foreach (int studentID in Students2)
            {
                Console.WriteLine("StudentID : " + studentID);
            }


           

            SortedSet<int> ExclusiveStudents = new SortedSet<int>(Students1);
            ExclusiveStudents.SymmetricExceptWith(Students2);
            foreach (int studentID in ExclusiveStudents)
            {
                Console.WriteLine("StudentID : " + studentID);
            }

            /*
            Performance Analysis:

            Populate a SortedSet<int> with 1000 random integers.
            Measure the time taken to add, search, and remove elements.
            */
            Random rnd  = new Random();
            List<int> list = new List<int>();
            for(int i = 0; i < 1000; i++)
            {
                list.Add(rnd.Next());   
            }
            Console.WriteLine("Random List "+string.Join(",",list));

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            list.Add(70);
            stopwatch.Stop();
            Console.WriteLine(" Time To Add = "+stopwatch.ElapsedTicks);



            /*
            Real - World Scenario:

            Create a SortedSet<string> for unique product names in a store.
            Use set operations to:
            Add new products.
            Remove discontinued products.
            Find products common to two different store branches.
            */


            SortedSet<string> branch1Products = new SortedSet<string> { "ProductA", "ProductB", "ProductC" };
            SortedSet<string> branch2Products = new SortedSet<string> { "ProductB", "ProductC", "ProductD" };

            // Add new products
            branch1Products.Add("ProductE");

            // Remove discontinued products
            branch1Products.Remove("ProductA");

            // Find common products
            var commonProducts = branch1Products.Intersect(branch2Products);
            Console.WriteLine($"Common Products: {string.Join(", ", commonProducts)}");


            Console.ReadKey();

        }
    }
}
