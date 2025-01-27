using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SortedList_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 1: Basic Operations
            Create a SortedList<int, string> to store student roll numbers and their names.
            Perform the following operations:
            Add at least 5 students.
            Retrieve the value for a specific key.
            Remove a student by key.
            Display all key - value pairs.
            */

            SortedList<int,string>Students = new SortedList<int,string>();
            Students.Add(1, "Oussama");
            Students.Add(2, "Saif");
            Students.Add(6, "Rami");
            Students.Add(4, "Sana");
            Students.Add(3, "Houssam");
            Students.Add(7, "Mouhaned");
            Students.Add(8, "Islem");

            Console.WriteLine("____________________________________________\n");
            foreach(KeyValuePair<int,string> kvp in Students)
            {
                Console.WriteLine($"Student RANK :  {kvp.Key} ,Student Name : {kvp.Value}");
            }

            Console.WriteLine("____________________________________________\n");

            string ClassMajor = Students[1];
            Console.WriteLine("The Major of the Class is :"+ClassMajor);
            Console.WriteLine("____________________________________________\n");

            Students.Remove(8);
            foreach (KeyValuePair<int, string> kvp in Students)
            {
                Console.WriteLine($"Student RANK :  {kvp.Key} ,Student Name : {kvp.Value}");
            }

            /*
            Task 2: Sorting by Value
            Create a SortedList<int, string> of product IDs and product names.
            Use LINQ to sort the list by product names alphabetically.
            Display the sorted key-value pairs.
            */
            SortedList<int,string>Products = new SortedList<int, string>() ;
            Products.Add(1, "Meat");
            Products.Add(2, "Eggs");
            Products.Add(3, "Milk");
            Products.Add(4, "Cheese");
            Products.Add(5, "Choklate");
            Products.Add(6, "Honey");

            foreach(KeyValuePair <int,string> kvp in Products)
            {
                Console.WriteLine($"ProductID : {kvp.Key}  ProductName : {kvp.Value}  ");
            }

            Console.WriteLine(" After Sorting ");
            var SortedProduct  =Products.OrderBy(kvp => kvp.Value).ToList();
            foreach (KeyValuePair<int, string> kvp in SortedProduct)
            {
                Console.WriteLine($"ProductID : {kvp.Key}  ProductName : {kvp.Value}  ");
            }

            /*
            Task 3: Reverse Order Retrieval
            Create a SortedList<string, double> for city names and their respective populations.
            Use LINQ to retrieve the cities in reverse alphabetical order.
            Display the results.
            */
            var Cities = new SortedList<string,double>() ;
            Cities.Add("Tunisia", 12);
            Cities.Add("Egypte", 99);
            Cities.Add("Lybie", 5);
            Cities.Add("Algeria", 65);
            Cities.Add("China", 1000);
            foreach (KeyValuePair< string,double> kvp in Cities)
            {
                Console.WriteLine($"City Name : {kvp.Key} Population : {kvp.Value}  ");
            }

            Console.WriteLine("______________________________________\n");

            var Ordered = Cities.OrderByDescending(kvp=>kvp.Key);
            foreach (KeyValuePair<string, double> kvp in Ordered)
            {
                Console.WriteLine($"City Name : {kvp.Key} Population : {kvp.Value}  ");
            }

            /*
            Task 4: Merging Two SortedLists
            Create two SortedList<int, string> objects with overlapping and unique keys.
            Merge them into a single SortedList, keeping unique keys only.
            Handle potential duplicates gracefully.
            */
            var Countries1 = new SortedList<string, double>();
            Countries1.Add("Tunisia", 12);
            Countries1.Add("Egypte", 99);
            Countries1.Add("Lybie", 5);
            Countries1.Add("Algeria", 65);
            Countries1.Add("China", 1000);

            Console.WriteLine("______________________________________\n");

            foreach (KeyValuePair<string, double> kvp in Countries1)
            {
                Console.WriteLine($"Country Name : {kvp.Key} Population : {kvp.Value}  ");
            }
            var Countries2 = new SortedList<string, double>();
            Countries2.Add("Tunisia", 12);
            Countries2.Add("Palestine", 99);
            Countries2.Add("Jordan", 50);
            Countries2.Add("Algeria", 65);
            Countries2.Add("Japan", 2000);
            Console.WriteLine("______________________________________\n");

            foreach (KeyValuePair<string, double> kvp in Countries2)
            {
                Console.WriteLine($"Country Name : {kvp.Key} Population : {kvp.Value}  ");
            }
            Console.WriteLine("______________________________________\n");

            var mergedCountries = Countries1.Concat(Countries2)
                .GroupBy(c => c.Key)
                .ToDictionary(g => g.Key, g => g.First().Value);

            foreach (var kvp in mergedCountries)
            {
                Console.WriteLine($"Country Name : {kvp.Key} Population : {kvp.Value}");
            }


            /*
            Task 5: Filtering by Condition
            Create a SortedList<int, int> representing employee IDs and their years of service.
            Use LINQ to filter out employees with more than 5 years of service.
            Display the filtered list.
            */
            SortedList<int,int>Employees = new SortedList<int,int>();
            Employees.Add(1, 2);
            Employees.Add(2, 3);
            Employees.Add(3, 4);
            Employees.Add(4, 5);
            Employees.Add(5, 6);
            Employees.Add(6, 7);
            Employees.Add(7, 8);    
            Employees.Add(8, 9);

            var EmployeeWithMore5YearsExperience = Employees.Where(kvp => kvp.Value > 5);
            foreach(KeyValuePair<int,int>kvp in EmployeeWithMore5YearsExperience)
            {
                Console.WriteLine($"EmployeeID {kvp.Key} ,EmployeeName : {kvp.Value}");
            }

            /*
            Task 7: Grouping by Value
            Create a SortedList<string, int> representing products and their prices.
            Group products by price ranges:
            Low(under 50).
            Medium(50 - 100).
            High(above 100).
            */

            SortedList<string,int> Products1 = new SortedList<string, int>();
            Products1.Add("Meat",50000);
            Products1.Add("Eggs",1400);
            Products1.Add("Milk", 1350);
            Products1.Add("Cheese", 3200);
            Products1.Add("Choklate", 5000);
            Products1.Add("Honey", 40000);
            Products1.Add("Car", 400000);
            Products1.Add("Bike", 140000);



            Console.WriteLine("All Products");
            foreach (KeyValuePair <string,int> kvp in Products1)
            {
                Console.WriteLine($"Product Name {kvp.Key} productName :  {kvp.Value}");
            }
            Console.WriteLine("_________________________________________");
            
            var LowProducts = Products1.Where(kvp => kvp.Value<50000);
            var MediumProducts = Products1.Where(kvp => kvp.Value > 50000 && kvp.Value < 100000);
            var HighProducts = Products1.Where(kvp => kvp.Value > 100000);
            Console.WriteLine("Low Products");
            foreach (KeyValuePair<string, int> kvp in LowProducts)
            {
                Console.WriteLine($"Product Name {kvp.Key} productName :  {kvp.Value}");
            }
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Medium Products");

            foreach (KeyValuePair<string, int> kvp in MediumProducts)
            {
                Console.WriteLine($"Product Name {kvp.Key} productName :  {kvp.Value}");
            }
            Console.WriteLine("_________________________________________");
            Console.WriteLine("HighProducts");

            foreach (KeyValuePair<string, int> kvp in HighProducts)
            {
                Console.WriteLine($"Product Name {kvp.Key} productName :  {kvp.Value}");
            }
            Console.WriteLine("_________________________________________");


            /*
            Task 8: Converting to Dictionary and LINQ Operations
            Create a SortedList<string, double> for store names and their ratings.
            Convert the SortedList to a Dictionary.
            Use LINQ to:
            Find the top - rated store.
            Calculate the average rating.
            */

            SortedList<string,double> Students1 = new SortedList<string,double>();
            Students1.Add("Oussama",19);
            Students1.Add("Saif", 18);
            Students1.Add("Rami", 13.5);
            Students1.Add("Sana", 18);
            Students1.Add("Houssam", 18);
            Students1.Add("Mouhaned", 17);
            Students1.Add("Islem", 14.5);
            var studentDict = Students1.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            // Find the top-rated student
            var topRatedStudent = studentDict.OrderByDescending(s => s.Value).First();
            Console.WriteLine($"Top-Rated Student: {topRatedStudent.Key}, Rating: {topRatedStudent.Value}");

            // Calculate the average rating
            var averageRating = studentDict.Average(s => s.Value);
            Console.WriteLine($"Average Rating: {averageRating}");

            Console.WriteLine("_________________________________________");

            //Dictionary<string, double> StudentDict = Students1.ToDictionary;


            /*
            Task 9: Performance Test
            Create a SortedList<int, string> with 1000 key - value pairs of random data.
            Measure the time taken to:
            Add a new key- value pair.
            Retrieve a value for a specific key.
            Remove an element by key.
            */
            var random = new Random();
            var largeSortedList = new SortedList<int, string>();
            for (int i = 0; i < 1000; i++)
            {
                largeSortedList.Add(i, $"Value-{random.Next(1000)}");
            }

            var stopwatch = new System.Diagnostics.Stopwatch();

            // Add operation
            stopwatch.Start();
            largeSortedList.Add(1001, "NewValue");
            stopwatch.Stop();
            Console.WriteLine($"Time to add: {stopwatch.ElapsedTicks} ticks");

            // Retrieve operation
            stopwatch.Restart();
            var value = largeSortedList[500];
            stopwatch.Stop();
            Console.WriteLine($"Time to retrieve: {stopwatch.ElapsedTicks} ticks");

            // Remove operation
            stopwatch.Restart();
            largeSortedList.Remove(500);
            stopwatch.Stop();
            Console.WriteLine($"Time to remove: {stopwatch.ElapsedTicks} ticks");





            /*
            Task 10: Complex Objects
            Create a SortedList<int, Employee> where Employee is a custom class with properties:
            Name
            Age
            Salary
            Add at least 5 employees.
            Use LINQ to find:
            The employee with the highest salary.
            All employees aged over 30.
            */


            SortedList<int, clsEmployee> EmployeesList = new SortedList<int, clsEmployee>();
            EmployeesList.Add(2, new clsEmployee("Oussama", 25, 850));
            EmployeesList.Add(7, new clsEmployee("Nour", 30, 1400));
            EmployeesList.Add(3, new clsEmployee("Basma", 42, 800));
            EmployeesList.Add(6, new clsEmployee("Farah", 25, 1200));
            EmployeesList.Add(10, new clsEmployee("Dr Robana", 60, 15000));

            var EmployeeWithHighestSalary = EmployeesList.OrderByDescending(emp => emp.Value.Salary).First();
            Console.WriteLine($" Employee name  ={EmployeeWithHighestSalary.Value.Name}  Salary : {EmployeeWithHighestSalary.Value.Salary}");
            





            Console.ReadKey();

        }

        class clsEmployee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary {  get; set; } 
            public clsEmployee(string name,int Age,double salary)
            {
                this.Name = name;
                this.Age = Age;
                this.Salary = salary;
            }
        }
    }
}
