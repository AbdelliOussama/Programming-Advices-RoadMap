using System;
using System.Collections;
using System.Linq;

namespace ArrayListTasks
{
    class Program
    {
        static void Main()
        {
            // Task 1: Basic CRUD Operations
            Console.WriteLine("Task 1: Basic CRUD Operations");
            ArrayList students = new ArrayList { "Oussama", "Houssam", "Saif", "Sana", "Rami" };

            Console.WriteLine("Initial Students:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Student Name: {students[i]}");
            }

            students.Remove("Sana");
            Console.WriteLine("After Removing 'Sana':");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Student Name: {students[i]}");
            }

            // Task 2: Sort and Filter
            Console.WriteLine("\nTask 2: Sort and Filter");
            ArrayList products = new ArrayList { 1200, 30, 15, 200, 150, 40 };

            Console.WriteLine("Initial Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product Price: {product}");
            }

            var filteredProducts = products.Cast<int>().Where(x => x > 100).ToList();
            Console.WriteLine("Filtered Products (Price > 100):");
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Product Price: {product}");
            }

            products.Sort();
            Console.WriteLine("Sorted Products (Ascending):");
            foreach (var product in products)
            {
                Console.WriteLine($"Product Price: {product}");
            }

            products.Reverse();
            Console.WriteLine("Sorted Products (Descending):");
            foreach (var product in products)
            {
                Console.WriteLine($"Product Price: {product}");
            }

            // Task 3: Mixed Data Types
            Console.WriteLine("\nTask 3: Mixed Data Types");
            ArrayList mixedList = new ArrayList { "Salim", 120, DateTime.Now, 2480, 11, "Twins" };

            Console.WriteLine("Initial Mixed List:");
            foreach (var item in mixedList)
            {
                Console.WriteLine($"{item} ({item.GetType()})");
            }

            var integers = mixedList.OfType<int>().ToList();
            Console.WriteLine($"Sum of Integers: {integers.Sum()}");

            // Task 4: Reverse a List
            Console.WriteLine("\nTask 4: Reverse a List");
            ArrayList dates = new ArrayList
            {
                DateTime.Now,
                DateTime.Parse("2023-11-18"),
                DateTime.Parse("2022-02-20"),
                DateTime.Parse("2020-01-12")
            };

            Console.WriteLine("Initial Dates:");
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date);
            }

            dates.Reverse();
            Console.WriteLine("Reversed Dates:");
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date);
            }

            // Task 5: Custom Objects
            Console.WriteLine("\nTask 5: Custom Objects");
            ArrayList employees = new ArrayList
            {
                new Employee("Oussama", 650),
                new Employee("Sana", 750),
                new Employee("Farah", 1200),
                new Employee("Basma", 800),
                new Employee("Amani", 700),
                new Employee("Robbana", 10000),
                new Employee("Wejdene", 1300)
            };

            var highSalaryEmployees = employees.OfType<Employee>().Where(x => x.Salary > 1000);
            Console.WriteLine("Employees with Salary > 1000:");
            foreach (var emp in highSalaryEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }
            public Employee(string name, int salary)
            {
                Name = name;
                Salary = salary;
            }
        }
    }
}
