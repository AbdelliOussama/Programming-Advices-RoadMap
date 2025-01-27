using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 20, 30, 40, 50 };

            // Access elements
            Console.WriteLine($"First element: {numbers[0]}");

            // Update element
            numbers[1] = 25;
            Console.WriteLine($"Updated array: {string.Join(", ", numbers)}");

            // Array Length
            Console.WriteLine($"Array length: {numbers.Length}");


            // Filter elements greater than 25
            var filtered = numbers.Where(x => x > 25);
            Console.WriteLine("Filtered: " + string.Join(", ", filtered));

            // Sum of elements
            int sum = numbers.Sum();
            Console.WriteLine("Sum: " + sum);

            // Find maximum
            int max = numbers.Max();
            Console.WriteLine("Maximum: " + max);





            var students = new[] { "John", "Alice", "Bob" };
            var scores = new[] { 85, 90, 75 };

            // Zip: Combine two arrays
            var studentScores = students.Zip(scores, (name, score) => $"{name}: {score}");
            Console.WriteLine(string.Join("\n", studentScores));

            // Group: Group students based on score ranges
            var groupedScores = scores.GroupBy(score => score / 10);
            foreach (var group in groupedScores)
            {
                Console.WriteLine($"Group {group.Key * 10}s: {string.Join(", ", group)}");
            }



            int[,] matrix = { { 1, 2 }, { 3, 4 } };

            // Access element
            Console.WriteLine($"Element at (1,1): {matrix[1, 1]}");

            // Iterate through rows and columns
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            /*
            Practice Tasks:
            Task 1: Filter Even Numbers
            Create an array of integers. Use LINQ to filter even numbers and calculate their sum.
            */
            int[] Numbers1 = new int[10];
            Numbers1[0] = 178;
            Numbers1[1] = 1;
            Numbers1[2] = 18;
            Numbers1[3] = 11;
            Numbers1[4] = 110;
            Numbers1[5] = 20;
            Numbers1[7] = 17;
            Numbers1[8] = 12;
            Numbers1[9] = 9;

            foreach (int i in Numbers1)
            {
                Console.WriteLine($"Number : {i}");
            }

            var FilteredNumber = Numbers1.Where(number => number % 2 == 0);

            Console.WriteLine("Filtered Number");
            foreach (int i in FilteredNumber)
            {
                Console.WriteLine($"Number : {i}");
            }

            var Sum = FilteredNumber.Sum();
            Console.WriteLine("Sum Of Even Numbers = " + sum);

            /*
            Task 2: Student Scores
            Create two arrays, one with student names and another with their scores.Combine them into a formatted string and find the student with the highest score.
            */
            string[] StudentNames = { "Oussama", "Saif", "Rami", "Safa", "Houssam", "Ali", "Mouhamed" };
            int[] StudentScores = { 20, 18, 17, 12, 18, 14, 15 };

            var StudentNameScores = StudentNames.Zip(StudentScores, (name, score) => new { name = name, score = score });

            Console.WriteLine("Students Details " + string.Join(",", StudentNameScores));


            var TopStudent = StudentNameScores.OrderByDescending(student => student.score).First();
            Console.WriteLine($"The name of the Major Student is : {TopStudent.name} the scoe is {TopStudent.score}");
            /*
            Task 3: Multi - Dimensional Matrix Operations
            Create a 3x3 matrix and write a program to calculate the sum of rows and columns.
            */
            int[,] matrix1 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Calculate row sums
            Console.WriteLine("Row Sums:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    rowSum += matrix1[i, j];
                }
                Console.WriteLine($"Row {i + 1}: {rowSum}");
            }

            // Calculate column sums
            Console.WriteLine("Column Sums:");
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                int colSum = 0;
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    colSum += matrix1[i, j];
                }
                Console.WriteLine($"Column {j + 1}: {colSum}");


                /*
                Task 4: Sorting and Filtering
                Given an array of product prices, filter prices above a certain threshold and sort the results in descending order.
                */
                double[] prices = { 19.99, 5.49, 25.00, 45.99, 12.99 };

                // Filter prices above threshold
                double threshold = 15.0;
                var filteredPrices = prices.Where(p => p > threshold).OrderByDescending(p => p);
                Console.WriteLine("Filtered and Sorted Prices: " + string.Join(", ", filteredPrices));


                /*
                Task 5: Grouping Data
                Create an array of ages.Group them into ranges(e.g., 0 - 10, 11 - 20) and count the number of people in each range.
                */
                int[] ages = { 3, 7, 12, 18, 25, 32, 45, 55, 63 };

                // Group ages into ranges
                var groupedAges = ages.GroupBy(age => age / 10);
                foreach (var group in groupedAges)
                {
                    Console.WriteLine($"Group {group.Key * 10}-{(group.Key * 10) + 9}: {group.Count()} people");
                }
                Console.ReadKey();
            }
        }
    }
}
