using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HashSet_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Apple"); // Duplicate, will be ignored

            Console.WriteLine($"Fruits: {string.Join(", ", fruits)}");
            fruits.Remove("Banana");
            Console.WriteLine($"Contains Apple? {fruits.Contains("Apple")}");



            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5, 6 };

            set1.UnionWith(set2); // { 1, 2, 3, 4, 5, 6 }
            Console.WriteLine(string.Join(",", set1));
            set1.IntersectWith(new HashSet<int>() { 2, 3, 5 }); // { 3, 5 }
            Console.WriteLine(string.Join(",", set1));
            set1.ExceptWith(new HashSet<int>() { 5 }); // { 3 }
            Console.WriteLine(string.Join(",",set1));



            // Task 1 Write a program to accept integers from the user until they enter -1.
            //Store only unique numbers in a HashSet and display them.
            int Number;
            HashSet<int> set = new HashSet<int>();

            do
            {
                Console.WriteLine("Enter A Number (-1 to stop): ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number != -1)
                {
                    set.Add(Number);
                }
            }
            while (Number != -1);

            Console.WriteLine("Unique Numbers Entered:");
            foreach (int number in set)
            {
                Console.WriteLine(number);
            }


            // Task 2: Create two HashSet<int>: First set: { 1, 2, 3, 4, 5} Second set: { 4, 5, 6, 7, 8}
            // Perform the following: Find the union.
            // Find the intersection.
            // Find the difference(elements in the first set but not in the second).

            HashSet<int> set5 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set6 = new HashSet<int> { 4, 5, 6, 7, 8 };

            set5.UnionWith(set6);
            Console.WriteLine(string.Join(",",set5));

            set5.IntersectWith(set6);
            Console.WriteLine(string.Join(",",set5));

            set5.ExceptWith(set6);
            Console.WriteLine(string.Join(",", set5));


            //Task 3:  Store a list of words in a HashSet. Allow the user to enter words to check if they are valid(present in the set). If the word is valid, print a success message.
            HashSet<string>Family = new HashSet<string>() { "Mother","Baba","Salim","Oussama","Asad","Saif","Anas","Sarra","asma"};
            if(Family.Contains("Barrani"))
            {
                Console.WriteLine("yes Barrani Is One Of Our Family ");
            }
            else
            {
                Console.WriteLine("This Person Does Not Belong To Our Family");
            }



            int[] array = { 10, 20, 10, 30, 20, 40 };
            HashSet<int> UniqueNumber = new HashSet<int>(array);
            foreach(int number in UniqueNumber) 
                { Console.WriteLine(number.ToString()); }

            // Task 5: Subset Check  Create two HashSet<int>:First set: { 1, 2, 3, 4, 5} Second set: { 2, 3}

            HashSet<int>set3 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set4 = new HashSet<int>() { 2, 3 };

            bool IsSubset = set4.IsSubsetOf(set3);
            Console.WriteLine("Set 4 IsSubset Of Set3 ?? : "+IsSubset);



            Console.ReadKey();
        }
    }
}
