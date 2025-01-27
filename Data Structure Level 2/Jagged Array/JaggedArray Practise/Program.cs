using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JaggedArray_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[2][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 }
            };

            // Display the elements
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Row {i}: {string.Join(", ", jaggedArray[i])}");
            }





            int[][] jaggedArray1 = new int[3][]
            {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50 },
                new int[] { 60, 70, 80, 90 }
            };

            // Sum of each row
            var rowSums = jaggedArray1.Select(row => row.Sum());
            Console.WriteLine($"Row Sums: {string.Join(", ", rowSums)}");

            // Flatten the jagged array
            var flattened = jaggedArray1.SelectMany(row => row);
            Console.WriteLine($"Flattened Array: {string.Join(", ", flattened)}");

            // Find all numbers greater than 50
            var greaterThanFifty = jaggedArray1.SelectMany(row => row).Where(x => x > 50);
            Console.WriteLine($"Numbers > 50: {string.Join(", ", greaterThanFifty)}");


            /*
            Task 1: Basic Jagged Array
            Create a jagged array representing scores for students in 3 subjects, with each student having a varying number of scores.Print all scores for each student.
            */
            int[][] Students = new int[3][];
            Students[0] = new int[] {15,17,19,20};
            Students[1] = new int[] {11,10,14,7,12,13};
            Students[2] = new int[] { 9, 12, 10 };

            for(int i = 0;i < Students.Length;i++)
            {
                Console.WriteLine($"Student Number : ({i+1}) " + string.Join(",", Students[i]));
            }





            /*
            Task 2: Find Max Score
            Write a program to find the maximum score for each student using LINQ.
            */
            var FlattenStudents = Students.SelectMany(scores=> scores);
            Console.WriteLine("Flatten Array students "+string.Join(",",FlattenStudents));

            var MaximumScore = FlattenStudents.Max();
            Console.WriteLine("The Maximum Score is"+MaximumScore);

            /*
            Task 3: Average Score Calculation
            Calculate and display the average score of all students combined.
            */
            var AvgScore = FlattenStudents.Average();
            Console.WriteLine("The Average of The Score is "+AvgScore);

            /*
            Task 4: Row - wise Operations
            Create a jagged array of 3 rows.Write LINQ queries to:
            Find the minimum value in each row.
            Count the number of elements greater than 10 in all rows combined.
            */
            for(int i = 0;i<=Students.Length; i++)
            {
                Console.Write($" The Minimum of Row {i}:  = " + Students[i].Min());
            }
            var NumberGreaterThan10  = FlattenStudents.Where(x=>x>10).Cast<int>().Count();
            Console.WriteLine(" The Number Of Elements Greater Than Ten Is " +NumberGreaterThan10);
             
            /*
            Task 5: Merge Rows
            Flatten a jagged array into a single array and sort the resulting array.
            */
            var SortedStudent = FlattenStudents.Cast<int>().OrderBy(x=>x);
            Console.WriteLine("Sorted Students " + string.Join(",", SortedStudent));
            /*
            Task 6: Jagged Array Matrix Multiplication
            Create a jagged array to represent a sparse matrix and write a program to perform matrix multiplication using another jagged array.
            */


            Console.ReadKey();
        }
    }
}
