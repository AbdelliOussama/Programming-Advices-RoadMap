using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HashTable_Examples_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();

            // Adding key-value pairs
            ht.Add(1, "Apple");
            ht.Add(2, "Banana");
            ht.Add(3, "Cherry");

            // Accessing values using keys
            Console.WriteLine("Item with key 2: " + ht[2]);

            // Displaying all key-value pairs
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            // Checking if a key exists
            Console.WriteLine("Contains key 3? " + ht.ContainsKey(3));

            // Removing an item
            ht.Remove(1);
            Console.WriteLine("After removing key 1:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }




            Hashtable ht1 = new Hashtable
        {
            { "A", "Alpha" },
            { "B", "Beta" },
            { "C", "Gamma" }
        };

            Console.WriteLine("Keys:");
            foreach (var key in ht1.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nValues:");
            foreach (var value in ht1.Values)
            {
                Console.WriteLine(value);
            }



            Hashtable ht2 = new Hashtable
        {
            { "User1", "Alice" },
            { "User2", "Bob" },
            { "User3", "Charlie" }
        };

            // Update value for a key
            ht2["User2"] = "Ben";
            Console.WriteLine("Updated Hashtable:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }


            // Task 1
            /*
            Create a Hashtable to store student IDs (keys) and their grades (values). Allow the user to:
            Add a new student and grade.
            Update a grade for an existing student.
            Display all students and their grades.
            Search for a student by ID.
            */

            Hashtable StudentsTable = new Hashtable();
            StudentsTable.Add(1, 16);
            StudentsTable.Add(2, 12);
            StudentsTable.Add(3, 15);
            StudentsTable.Add(4, 7);
            StudentsTable.Add(5, 9);
            StudentsTable.Add(6, 13);
            StudentsTable.Add(7, 14);
            foreach(DictionaryEntry entry in StudentsTable)
            {
                Console.WriteLine($"Student ID :{entry.Key}   Student Grade : {entry.Value}");
            }
            StudentsTable[2] = 17;

            foreach (DictionaryEntry entry in StudentsTable)
            {
                Console.WriteLine($"Student ID :{entry.Key}   Student Grade : {entry.Value}");
            }

            if(StudentsTable.ContainsKey(1))
                Console.WriteLine("Student With ID 1 Exists ");
            else
                Console.WriteLine("Student Is Not Found");


            //Task  2
            //Use a Hashtable to count the frequency of each character in a string entered by the user.



            // TasK 3
            //Create a program where you store product names (keys) and their prices (values). 
            //Allow the user to Add new products and prices. Display all products with prices.
            //Find the price of a specific product by name.Remove a product by name.

            Hashtable Products = new Hashtable();
            Products.Add("Computer", 1200.00);
            Products.Add("Book", 340.0);
            Products.Add("Pen", 2.0);

            foreach (DictionaryEntry entry in Products)
            {
                Console.WriteLine($"Product Name: {entry.Key}, Price: {entry.Value}");
            }

            Console.WriteLine("Price of Computer: " + Products["Computer"]);

            Products.Remove("Pen");
            Console.WriteLine("After Removing Pen:");
            foreach (DictionaryEntry entry in Products)
            {
                Console.WriteLine($"Product Name: {entry.Key}, Price: {entry.Value}");
            }





            //Task4  
            //Implement a phone directory where names are the keys and phone numbers are the values.
            //Include:Searching for a contact by name.Adding, updating, or removing a contact.


            Hashtable Contacts = new Hashtable();
            Contacts.Add("Father", "524564544");
            Contacts.Add("Salim Brother", "3456775");
            Contacts.Add("Mother", "55346533");

            foreach (DictionaryEntry entry in Contacts)
            {
                Console.WriteLine($"Contact Name: {entry.Key}, Phone Number: {entry.Value}");
            }

            // Search for a contact
            string searchKey = "Mother";
            if (Contacts.ContainsKey(searchKey))
            {
                Console.WriteLine($"Phone number of {searchKey}: {Contacts[searchKey]}");
            }
            else
            {
                Console.WriteLine($"{searchKey} not found.");
            }

            // Remove a contact
            Contacts.Remove("Father");
            Console.WriteLine("After Removing Father:");
            foreach (DictionaryEntry entry in Contacts)
            {
                Console.WriteLine($"Contact Name: {entry.Key}, Phone Number: {entry.Value}");
            }
        }
    }
}
