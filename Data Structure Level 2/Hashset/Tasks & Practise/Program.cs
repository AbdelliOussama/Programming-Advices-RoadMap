using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tasks___Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task 1: Advanced Union and Intersection
             Create two HashSet<int> collections:
             First set: { 1, 2, 3, 4, 5 }
             Second set: { 4, 5, 6, 7, 8 }
             Perform and display:
             Union of the sets.
             Intersection of the sets.
             Symmetric difference(elements in either set but not in both).
             Verify results by checking set counts.
            */

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };

            Console.WriteLine("Set 1: " + string.Join(",", set1));
            Console.WriteLine("Set 2: " + string.Join(",", set2));

            // Union
            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2);
            Console.WriteLine("Union of Set1 and Set2: " + string.Join(",", unionSet));

            // Intersection
            HashSet<int> intersectionSet = new HashSet<int>(set1);
            intersectionSet.IntersectWith(set2);
            Console.WriteLine("Intersection of Set1 and Set2: " + string.Join(",", intersectionSet));

            // Symmetric Difference
            HashSet<int> symmetricDifference = new HashSet<int>(set1);
            symmetricDifference.SymmetricExceptWith(set2);
            Console.WriteLine("Symmetric Difference: " + string.Join(",", symmetricDifference));




            /*Task 2: Comparing Two Sets
            Create two HashSet<string> for student names:
            First class: { "Alice", "Bob", "Charlie", "David" }
            Second class: { "Eve", "Bob", "Alice", "Frank" }
            Check:
            If the first set is a superset of the second.
            If the second set is a subset of the first.
            */

            HashSet<string>FirstClasse = new HashSet<string>() { "Alice", "Bob", "Charlie", "David" };
            HashSet<string> SecondClass = new HashSet<string>() { "Eve", "Bob", "Alice", "Frank" };

            bool IsSuperSet = FirstClasse.IsSupersetOf(SecondClass);
            bool IsSubset = SecondClass.IsSubsetOf(FirstClasse);
            Console.WriteLine("The First Class Is a superSet Of The Second Class isn't ??? : "+IsSuperSet);
            Console.WriteLine("The Second Class Is a subSet Of The First Class isn't ??? : " + IsSubset);

            /*
            Task 3: Removing Elements Based on Condition
            Create a HashSet<int> of random integers.
            Remove all numbers divisible by 3 using the RemoveWhere() method.
            */
            Random random = new Random();
            HashSet<int> randomSet = new HashSet<int>();
            for (int i = 0; i < 20; i++)
            {
                randomSet.Add(random.Next(1, 101));
            }

            Console.WriteLine("Original Set: " + string.Join(",", randomSet));

            // Remove all numbers divisible by 3
            randomSet.RemoveWhere(x => x % 3 == 0);
            Console.WriteLine("After Removing Multiples of 3: " + string.Join(",", randomSet));

            /*
            Task 4: Tracking Unique Visitors
            Simulate a website's unique visitor tracking system using a HashSet<string> to store visitor IPs.
            Add IP addresses as visitors arrive.
            Display the total number of unique visitors.
            Allow the user to query if a specific IP has visited.
            */
            HashSet<string> visitorsIps = new HashSet<string>()
            {
                "145.36.244.99", "93.227.56.209", "250.13.45.128",
                "85.129.63.255", "174.244.73.7", "123.8.245.37",
                "233.116.73.52", "3.99.77.200", "145.222.17.135", "29.80.66.8"
            };

            Console.WriteLine("Number of Visitors: " + visitorsIps.Count);

            Console.WriteLine("Enter a Visitor IP Address:");
            string visitorIp = Console.ReadLine()?.Trim();
            if (visitorsIps.Contains(visitorIp))
            {
                Console.WriteLine("This Visitor Already Visited the Site.");
            }
            else
            {
                visitorsIps.Add(visitorIp);
                Console.WriteLine("New Visitor Added!");
            }


            /*
            Task 5: Case - Insensitive Strings
            Create a HashSet<string> of case -insensitive strings.
            Add some names in different cases(e.g., "Alice", "alice", "ALICE").
            Ensure only unique names are stored by providing a custom IEqualityComparer.
            */
            //   class CaseInsensitiveComparer : IEqualityComparer<string>
            //   {
            //    public bool Equals(string x, string y) => string.Equals(x, y, StringComparison.OrdinalIgnoreCase);

            //    public int GetHashCode(string obj) => obj.ToLower().GetHashCode();
            //   }

            //// Usage
            //    HashSet<string> names = new HashSet<string>(new CaseInsensitiveComparer());
            //    names.Add("Alice");
            //    names.Add("alice");
            //    names.Add("ALICE");
            //    Console.WriteLine("Unique Names Count: " + names.Count); // Should be 1

            /*
            Task 6: Two - Way Subset Check
            Create two HashSet<int>:
            Set A: { 10, 20, 30, 40 }
            Set B: { 30, 40 }
            Write a method that:
            Checks if Set A is a superset of Set B.
            Checks if Set B is a subset of Set A.
            Extend the method to support custom comparers(e.g., modulo - based comparison).
            */
            HashSet<int> setA = new HashSet<int>() { 10, 20, 30, 40 };
            HashSet<int> setB = new HashSet<int>() { 30, 40 };

            bool isSuperset = setA.IsSupersetOf(setB);
            bool isSubset = setB.IsSubsetOf(setA);
            Console.WriteLine("Set A is a superset of Set B: " + isSuperset);
            Console.WriteLine("Set B is a subset of Set A: " + isSubset);

            // Modulo-based check
            bool moduloSubset = setB.All(x => setA.Any(y => x % y == 0));
            Console.WriteLine("Set B is a modulo-based subset of Set A: " + moduloSubset);



            /*
            Task 7: HashSet Performance Test
            Create a List<int> with 1 million random integers.
            Convert the list to a HashSet<int>.
            Measure the time taken to:
            Add elements.
            Check membership.
            Remove elements.
            Compare the performance with a List<int>.
            */





            /*
            Task 8: Employee Directory
            Create a HashSet<string> to store employee email IDs.
            Add, update, and remove email IDs.
            Prevent duplicate entries while updating.
            */




            /*
            Task 9: Detect Duplicates in a List
            Create a List<int> with duplicate values.
            Use a HashSet<int> to identify and print all duplicate values.
            */




            /*
           Task 10: Complex Objects
            Create a class Student with properties ID and Name.
            Create a HashSet<Student> to store student records.
            Ensure HashSet prevents duplicate entries based on ID by overriding Equals and GetHashCode.
            */



            /*
            ask 11: Merging Unique Data
            Use three HashSet<string> to simulate datasets from different sources.
            Merge all datasets, ensuring only unique data remains.
            */

            HashSet<string>People1 = new HashSet<string>();
            HashSet<string>People2 = new HashSet<string>();
            HashSet<string>People3 = new HashSet<string>();
            People1.SymmetricExceptWith(People2);
            People1.SymmetricExceptWith(People3);
            Console.WriteLine(" Non Dûplicate Person"+string.Join(",",People1));

            /*
            Task 12: Finding Anagrams
            Create a HashSet<string> to store words.
            Write a method to find all anagrams of a given word in the set.
            */




            /*
            Task 13: HashSet to HashMap
            Create a HashSet<string> with unique product names.
            Convert the HashSet into a Dictionary<string, int>, where the value is the length of each product name.
            */
            HashSet<string>Products = new HashSet<string>();
            Products.Add("Milk");
            Products.Add("Soda");
            Products.Add("Tea");
            Products.Add("Sugar");
            Products.Add("Salt");
            Products.Add("Bread");
            Products.Add("Butter");

            Dictionary<string,int>Productss = Products.ToDictionary(item=>item,item=>item.Length);
            foreach (KeyValuePair<string, int> kvp in Productss)
            {
                Console.WriteLine(kvp.Key + "=" + kvp.Value);
            }















            Console.ReadKey();
        }
    }
}
