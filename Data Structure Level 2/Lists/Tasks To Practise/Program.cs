using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_To_Practise
{
    public class clsPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public clsPerson(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            return "Name : " + Name + " " + "Age: " + Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 1: Shuffling and Sorting
            Create a list of integers.
            Write a method to shuffle the list randomly(using Random).
            Sort the list in descending order using LINQ.
            Sort the list in ascending order using the Sort() method.
            */
            Random rnd = new Random();
            List<int>Numbers = new List<int>() { 1 ,23, 36, 236, 235, 352, 11 ,2, 135, 1, 2, 37, 56, 3, 33, 2 };
            Console.WriteLine("Original List    "+ string.Join(",",Numbers ) );

            Console.WriteLine("Shufled List   " + string.Join(",", Numbers.OrderBy(x => rnd.Next().ToString())));

            
            Console.WriteLine(" List Sorted Desc Using LINQ    " + string.Join(",", Numbers.OrderByDescending(x => x)));


            Numbers.Sort();
            Console.WriteLine(" List Sorted   " + string.Join(",", Numbers));


            /*
            Task 2: Removing Elements Based on Condition
            Create a list of strings representing names.
            Remove all names starting with a specific letter(e.g., 'A').
            Use RemoveAll() for this task.
            */

            List<string>Names = new List<string>();
            Names.Add("Oussama");
            Names.Add("Salim");

            Console.WriteLine(string.Join(";",Names));

            Names.RemoveAll(x => x.StartsWith("A"));
            Console.WriteLine(string.Join(";", Names));


            /*
            Task 3: Finding the Longest String
            Create a list of strings.
            Use LINQ to find the longest string in the list.
            Display the string and its length.
            */


            List<string>Words= new List<string>() { "alpha","Beta","Gamma","zeta","yotta","Octa"};
            string LongestWord = Words.OrderByDescending(x=>x.Length).First();
            Console.WriteLine($"The Longest Word is {LongestWord} with Number Of Char = {LongestWord.Length}");


            /*
            Task 4: Partition a List
            Create a list of integers.
            Partition the list into two smaller lists:
            One containing numbers greater than or equal to 50.
            Another containing numbers less than 50.
            */
            List<int>numbers = new List<int>() { 1,43,565,2,23,44,12,75,2,193};
            var NumberGreaterThan50 = numbers.Where(x => x >= 50);
            Console.WriteLine("Number Greater Than 50 : "+string.Join(",",NumberGreaterThan50));

            var NumberLessThan50 = numbers.Where(x => x < 50);
            Console.WriteLine("Number Less Than 50 : " + string.Join(",", NumberLessThan50));


            /*
            Task 5: Nested Lists
            Create a List<List<int>> representing a matrix(e.g., 3x3 grid of integers).
            Add numbers to each sublist to simulate a matrix structure.
            Display the matrix row by row.
            */
            List<List<int>>Matrix = new List<List<int>>();
            Matrix.Add(new List<int> { 1, 5, 7, 15 });
            Matrix.Add(new List<int> { 1, 5, 7, 15 });
            Matrix.Add(new List<int> { 1, 5, 7, 15 });
            Matrix.Add(new List<int> { 1, 5, 7, 15 });
            foreach(List<int>Row in Matrix)
            {
                Console.WriteLine(string.Join(" ",Row));
            }


            /*
            Task 6: Custom Sorting
            Create a class Person with properties:
            Name(string)
            Age(int)
            Create a list of Person objects.
            Sort the list by Age in ascending order.
            Then, sort it by Name alphabetically.
            */
            List<clsPerson>Peoples = new List<clsPerson>()
            {
                new clsPerson(61,"Baba"),
                new clsPerson(47,"Omi"),
                new clsPerson(14,"Anas"),
                new clsPerson(27,"Asma"),
                new clsPerson(25,"Oussama"),
                new clsPerson(25,"Salim"),
                new clsPerson(29,"Sarra")
            };
            Peoples.ForEach(x=> Console.WriteLine(x.ToString()));

            Console.WriteLine("_______________________________________\n");

            Peoples = Peoples.OrderBy(x => x.Age).ToList();
            Peoples.ForEach(x => Console.WriteLine(x.ToString()));

            Console.WriteLine("_______________________________________\n");

            Peoples = Peoples.OrderBy(x => x.Name).ToList();
            Peoples.ForEach(x => Console.WriteLine(x.ToString()));



            Console.ReadKey();

        }
    }
}
