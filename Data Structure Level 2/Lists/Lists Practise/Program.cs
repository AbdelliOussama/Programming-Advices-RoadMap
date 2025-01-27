using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Lists_Practise
{
    internal class Program
    {
        //public static void ReadNameFromUser(ref List<string> list)
        //{
        //    string Answer = "Yes";
        //    while(Answer == "Yes")
        //    {
        //        string Name = "";
        //        Console.WriteLine("Enter Person Name");
        //        Name = Console.ReadLine();
        //        list.Add(Name);

        //        Console.WriteLine("Are You Want To Add Another Person ?");
        //        Answer = Console.ReadLine();
        //    }
        //    DrawMainMenue(list);

        //}
        //public static void RemoveFromPeoplesList( ref List<string> list)
        //{
        //    Console.WriteLine("Enter The Person Name You Want To Remove");
        //    string Name =Console.ReadLine();
        //    list.Remove(Name);
        //}
        //public static void DisplayPeoples(List<string> list)
        //{
        //    list.ForEach(x => Console.WriteLine(x));
        //}
        //public static void OrderPeople(List<string> list)
        //{
        //    list.OrderBy(x=>x);
        //}
        //public static void ExcuteProgram(List<string> list)
        //{
        //    Console.WriteLine("Pleasse Enter Your Choice :)");
        //    string Choice = Console.ReadLine();
        //    switch(Choice)
        //    {
        //        case "1":
        //            ReadNameFromUser(ref list);
        //            break;
        //        case "2":
        //            RemoveFromPeoplesList (ref list);
        //            break;
        //        case "3":
        //            DisplayPeoples ( list);
        //            break;
        //        case "4":
        //            OrderPeople(list);
        //            break;
        //    }
        //}
        //public static void DrawMainMenue(List<string>list)
        //{

        //    Console.WriteLine("___________________________");
        //    Console.WriteLine("[1] Add Person");
        //    Console.WriteLine("[2] Remove Person");
        //    Console.WriteLine("[3] Display Peoples List ");
        //    Console.WriteLine("[1] Sort People's List");
        //    Console.WriteLine("___________________________");
        //    ExcuteProgram(list);
        //}

        static void Main(string[] args)
        {


            //  Task 1


            /* 
                Create a list of strings representing your favorite movies.
                Add 5 movies to the list.
                Remove one movie and display the updated list.
            */


            //List<string> MovieList = new List<string>();
            //MovieList.Add("Bolice");
            //MovieList.Add("Harga");
            //MovieList.Add("Harba");
            //MovieList.Add("Batman");
            //MovieList.Add("SpiderMan");

            //Console.WriteLine($"My Movie List Number = {MovieList.Count}");

            //for(int i = 0; i < MovieList.Count; i++)
            //{
            //    Console.WriteLine("Movie : " + MovieList[i]);
            //}
            //Console.WriteLine("_______________________________________________\n");
            //MovieList.Remove("Harba");
            //foreach(string Movie in  MovieList)
            //{
            //    Console.WriteLine(Movie);
            //}
            //Console.WriteLine("_______________________________________________\n");

            //MovieList.AddRange(new List<string>() {"Zombie","Zoro","Harry Poter" });

            //MovieList.ForEach(movie => Console.WriteLine(movie));


            // Task 2


            //List<int> myIntList = new List<int>() { 1, 5,6,0,6,77,55,736,364,79,-5,363,545,343,5,76,34 };
            //if(myIntList.Contains(545))
            //{
            //    Console.WriteLine("Yes The Number 545 Exists At Index :"+myIntList.IndexOf(545));
            //}

            //// Task 3

            //List<int> myIntList1 = new List<int>() { 1, 5, 6, 0, 6, 77, 55, 736, 364, 79, -5, 363, 545, 343, 5, 76, 34 };
            //myIntList1.Sort();
            //Console.WriteLine("My Sorted List : "+string.Join(",",myIntList1));

            //myIntList.OrderBy(x => x);
            //Console.WriteLine("My Sorted List Using LINQ : " + string.Join(",", myIntList1));


            //myIntList1.Reverse();
            //Console.WriteLine("My Reversed List : " + string.Join(",", myIntList1));


            //// Task 4
            //List<string> myFamilyList = new List<string>();
            //myFamilyList.AddRange(new List<string>() { "Oussama", "Salim", "Asma", "Sarra", "As3ed", "Saif", "Anas", "El Ghali Baba", "El Ghalia Omi","Barrani","Foulen" });

            //Console.WriteLine("My Family Rabi Ya7fedhhom "+string.Join("/"+myFamilyList));

            //myFamilyList.RemoveRange(8,myFamilyList.Count);
            //Console.WriteLine("My Family Without Strangers " + string.Join("/" + myFamilyList));

            //Task 5
                /*
                Custom Example
                Create a program that reads names from the user and stores them in a list.
                Provide options to add, remove, display, and sort names in the list.
                */
            //List<string> Peoplelist = new List<string>();
            //DrawMainMenue(Peoplelist);

            //Task1
            List<int>UniqueNumbers = new List<int>();
            string Answer = "yes";
            while(Answer =="Yes".ToLower())
            {
                Console.WriteLine("Enter A Number");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (!UniqueNumbers.Contains(Number))
                {
                    UniqueNumbers.Add(Number);
                }
                else
                    Console.WriteLine("Number Already Exists");
                Console.WriteLine(" Are You Want To Add Another Number ?");
                Answer =  Console.ReadLine();
            }
            foreach(int number in UniqueNumbers)
            {
                Console.WriteLine(number);
            }


            //Task 2




            //Task 3
            List<int> Numbers = new List<int>() {1,5,6,9,26,5467,878,6,56 };
            Console.WriteLine("The Maximum Of The List Is"+Numbers.Max());
            Console.WriteLine("The Minimum Of The List Is" + Numbers.Min());
            Console.WriteLine("The Average Of The List Is" + Numbers.Average());

            //Task 4
            /*4. Merge and Remove Duplicates
            Create two separate lists of integers.
            Merge them into a single list and remove duplicates.

            */
            List<int> Numbers1 = new List<int>() { 1, 5, 6, 9, 26, 5467, 878, 6, 56 };
            List<int> Numbers2 = new List<int>() { 11, 53, 6, 9, 26, 5467, 87880, 69, 536 };
            foreach(int number in Numbers1)
            {
                if(!Numbers2.Contains(number))
                {
                    Numbers.Add(number);
                }
            }
            Console.WriteLine("All Numbers"+string.Join(", ", Numbers));

            //Task 5
            /* Filter by Condition
            Create a program that filters a list based on a user-defined condition.
            Example: Return all even numbers from a list of integers.
            */


            List<int> Numbers3 = new List<int>() { 1, 5, 6, 9, 26, 5467, 878, 6, 56 };
            Console.WriteLine("Even Numbers"+string.Join(",",Numbers.FindAll(n=>n%2==0)));



            //Task 6  Split Full Name
            List<string> fullNames = new List<string> { "John Doe", "Jane Smith", "Alice Johnson" };
            List<string> firstNames = new List<string>();
            List<string> lastNames = new List<string>();

            foreach (string name in fullNames)
            {
                var parts = name.Split(' ');
                firstNames.Add(parts[0]);
                lastNames.Add(parts[1]);
            }

            Console.WriteLine("First Names: " + string.Join(", ", firstNames));
            Console.WriteLine("Last Names: " + string.Join(", ", lastNames));

            //Task 7  Find Common Elements

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };

            List<int> commonElements = list1.Intersect(list2).ToList();

            Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));


            //  Task 11 Reverse Words
            List<string> sentences = new List<string> { "Hello World", "C# Collections" };
            List<string> reversedSentences = sentences
                .Select(sentence => string.Join(" ", sentence.Split(' ').Reverse()))
                .ToList();

            Console.WriteLine("Reversed Sentences: " + string.Join(", ", reversedSentences));

            //Task 12  Find Longest Word

            List<string> words = new List<string> { "apple", "banana", "cherry", "watermelon" };
            string longestWord = words.OrderByDescending(word => word.Length).First();

            Console.WriteLine("Longest Word: " + longestWord);



            //Task 13 Prime Numbers

            List<int> primeNumbers = Enumerable.Range(2, 100).Where(IsPrime).ToList();

            Console.WriteLine("Prime Numbers: " + string.Join(", ", primeNumbers));

            // Helper Function
            bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }


            //Task 17 Palindrome Checker

            List<string> words1 = new List<string> { "level", "radar", "hello", "world" };
            List<string> palindromes = words1.Where(word => word.SequenceEqual(word.Reverse())).ToList();

            Console.WriteLine("Palindromes: " + string.Join(", ", palindromes));


            Console.ReadKey();







}
}
}
