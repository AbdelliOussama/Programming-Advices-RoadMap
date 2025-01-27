using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Add students
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            students.Add(3, "Charlie");
            students.Add( 4, "David" );

            // Access a value by key
            Console.WriteLine("Student with ID 1: " + students[1]);

            // Check if a key exists
            if (students.ContainsKey(2))
            {
                Console.WriteLine("Student with ID 2 exists.");
            }

            // Remove a student
            students.Remove(3);

            // Iterate through the dictionary
            foreach (var kvp in students)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }

            // Try to get a value
            if (students.TryGetValue(2, out string name))
            {
                Console.WriteLine("Student with ID 2: " + name);
            }

            // Find students with IDs greater than 2
            var filteredStudents = students.Where(kvp => kvp.Key > 2);

            Console.WriteLine("Students with IDs greater than 2:");
            foreach (var kvp in filteredStudents)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }

            // Select only the names
            var names = students.Select(kvp => kvp.Value);
            Console.WriteLine("All student names: " + string.Join(", ", names));

            // Count students whose name starts with 'A'
            int count = students.Count(kvp => kvp.Value.StartsWith("A"));
            Console.WriteLine("Number of students whose name starts with 'A': " + count);




            //Task 1  
            //Task 1: Create a Phonebook

            //Create a dictionary where keys are names and values are phone numbers.
            // Add, update, search, and remove contacts from the phonebook.
            // Use LINQ to find all contacts whose names start with a specific letter.

            Dictionary<string,long> Contacts = new Dictionary<string,long>();
            Contacts.Add("Omi Lghalya", 55343283);
            Contacts.Add("Baba el Ghali", 93464532);
            Contacts.Add("Asma", 5434643);
            Contacts.Add("Salim ", 40456432);
            Contacts.Add("Sarra", 44232363);
            Contacts.Add("Asad", 7465734);
            Contacts.Add("Anas", 0000000000);
            Contacts.Add("Oussama", 93970921);

            foreach (var kvp in Contacts)
            {
                Console.WriteLine($"Name {kvp.Key}  ,PhoneNumber: {kvp.Value}");
            }
            Contacts["Salim"] = 44235232;

            if (Contacts.TryGetValue("Sarra", out long PhoneNumber))
                Console.WriteLine(" Sarra's Phone Number :  " + PhoneNumber);
            else
                Console.WriteLine("Sarra Is Not Found ");

            var FilterdContacts = Contacts.Where(kvp => kvp.Key.StartsWith("S"));
            foreach (var kvp in FilterdContacts)
            {
                Console.WriteLine($"Contact Name {kvp.Key}");
            }




            //Task 3: Product Catalog

            //Store product names as keys and prices as values.
            //Add functionality to filter products based on price range using LINQ. 
            //Find the most expensive and least expensive products.

            Dictionary<string,double> Products = new Dictionary<string,double>();
            Products.Add("Computer", 1200.0);
            Products.Add("Mouse", 10.0);
            Products.Add("KeyBoard", 25.00);
            Products.Add("Screen",150);
            Products.Add("Speakers", 40.0);

            var FilterdProducts = Products.Where(kvp => (kvp.Value > 150 && kvp.Value < 1500));
            foreach (var kvp in FilterdProducts)
            {
                Console.WriteLine($"ProductName :{kvp.Key}  Product Price {kvp.Value} ");
            }


            var mostExpensive = Products.OrderByDescending(kvp => kvp.Value).First();
            Console.WriteLine($"Most Expensive Product: {mostExpensive.Key} - Price: {mostExpensive.Value}");

            var leastExpensive = Products.OrderBy(kvp => kvp.Value).First();
            Console.WriteLine($"Least Expensive Product: {leastExpensive.Key} - Price: {leastExpensive.Value}");





            // Task 4: Grade Book Create a dictionary where keys are student names and values are lists of grades. 
            //Add functionality to calculate the average grade for each student using LINQ

            Dictionary<string, float> Students1 = new Dictionary<string, float>();
            Students1.Add("Oussama", 20);
            Students1.Add("Rami", 20);
            Students1.Add("Saif", 19);
            Students1.Add("Houssama", 18);
            Students1.Add("Mouhaned", 17);
            Students1.Add("Safwene", 13);
            Students1.Add("Zahra", 14);


            var ClassAverage = Students1.Average(kvp => kvp.Value);
            Console.WriteLine("The Average Of The Class = "+ClassAverage);

            // Task 5: Inventory Management  Create a dictionary where keys are product names and values are quantities.
            // Add, update, and remove products.
            // Use LINQ to find products with low stock.


            Dictionary<string, int> Products11 = new Dictionary<string,int>();
            Products11.Add("Computers", 1200);
            Products11.Add("Mouse", 10);
            Products11.Add("KeyBoard", 25);
            Products11.Add("Screen", 150);
            Products11.Add("Speakers", 40);


            Products11.Remove("KeyBoard");

            var lowStockProduct = Products.OrderBy(kvp => kvp.Value).First();
            Console.WriteLine($"Product with Lowest Stock: {lowStockProduct.Key} - Quantity: {lowStockProduct.Value}");



            Console.ReadKey();
        }
    }
    

}
