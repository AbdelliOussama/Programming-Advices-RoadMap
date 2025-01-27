using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BitArray_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Explanation and Basic Usage of BitArray
            // A BitArray is a collection that manages a compact array of bit values, represented as booleans (true or false).
            // Each bit represents a boolean value, where `true` means 1 and `false` means 0.

            // Use Cases:
            // 1. Compact representation of boolean values.
            // 2. Efficient memory usage for scenarios with a large number of boolean flags.
            // 3. Performing bitwise operations (AND, OR, XOR, NOT).

            // Creating a BitArray with an initial size and default value.
            BitArray bitArray = new BitArray(8, false); // 8 bits, all initialized to false.

            // Updating specific bits.
            bitArray[0] = true;
            bitArray[3] = true;

            Console.WriteLine("Initial BitArray:");
            foreach (bool bit in bitArray)
            {
                Console.Write(bit ? 1 : 0); // Display as 1 or 0.
            }
            Console.WriteLine();

            // Methods:

            // 1. NOT Operation (Negating all bits)
            bitArray.Not();
            Console.WriteLine("After NOT Operation:");
            foreach (bool bit in bitArray)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();

            // 2. AND Operation
            BitArray otherArray = new BitArray(new bool[] { true, true, false, false, true, false, true, false });
            bitArray.And(otherArray);
            Console.WriteLine("After AND Operation:");
            foreach (bool bit in bitArray)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();

            // 3. OR Operation
            bitArray.Or(new BitArray(new bool[] { false, false, true, true, false, true, false, true }));
            Console.WriteLine("After OR Operation:");
            foreach (bool bit in bitArray)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();

            // 4. XOR Operation
            bitArray.Xor(new BitArray(new bool[] { true, false, true, false, true, false, true, false }));
            Console.WriteLine("After XOR Operation:");
            foreach (bool bit in bitArray)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();

            // 5. CopyTo: Copy the BitArray to an array.
            bool[] boolArray = new bool[8];
            bitArray.CopyTo(boolArray, 0);
            Console.WriteLine("Copied to Boolean Array:");
            Console.WriteLine(string.Join(", ", boolArray));

            // 6. Combining BitArray with LINQ
            // Filtering bit values (true bits).
            var trueIndexes = bitArray.Cast<bool>().Select((value, index) => new { value, index })
                                        .Where(x => x.value)
                                        .Select(x => x.index);
            Console.WriteLine("Indexes of True Bits: " + string.Join(", ", trueIndexes));

            // Practice Tasks:

            // Task 1: Create a BitArray of 16 bits and initialize it with alternating true and false values.
            BitArray task1Array = new BitArray(16);
            for (int i = 0; i < task1Array.Length; i++)
            {
                task1Array[i] = (i % 2 == 0);
            }
            Console.WriteLine("Task 1 - Alternating True/False:");
            foreach (bool bit in task1Array)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();

            // Task 2: Perform NOT operation on the above BitArray and display the result.
            task1Array.Not();
            Console.WriteLine("Task 2 - After NOT Operation:");
            foreach (bool bit in task1Array)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();

            // Task 3: Find and display the indexes of all true bits in the above BitArray using LINQ.
            var task3TrueIndexes = task1Array.Cast<bool>().Select((value, index) => new { value, index })
                                              .Where(x => x.value)
                                              .Select(x => x.index);
            Console.WriteLine("Task 3 - Indexes of True Bits: " + string.Join(", ", task3TrueIndexes));

            // Task 4: Perform AND operation between two BitArrays and display the result.
            BitArray array1 = new BitArray(new bool[] { true, false, true, false, true });
            BitArray array2 = new BitArray(new bool[] { false, true, false, true, true });
            array1.And(array2);
            Console.WriteLine("Task 4 - Result of AND Operation:");
            foreach (bool bit in array1)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();


            /*
            Task 1: Bitwise Operations
            Create two BitArray objects of the same size and initialize them with random boolean values.
            Perform the following bitwise operations:
                        AND
                        OR
                        XOR
            Print the results for each operation.
            */
            BitArray bitarr1 = new BitArray(10);
            BitArray bitarr2 = new BitArray(10);

            Random rnd = new Random();
            for (int i = 0; i <bitarr1.Count;i++)
            {
                bitarr1[i] = rnd.Next(2) == 1;
            }
            for (int i = 0; i < bitarr2.Count; i++)
            {
                bitarr2[i] = rnd.Next(2) == 1;
            }
            Console.WriteLine(" Random BitArray 1 : "+BitArrayToString(bitarr1));
            Console.WriteLine(" Random BitArray 2 : " + BitArrayToString(bitarr2));

            BitArray ResultAnd = new BitArray(bitarr1);
            ResultAnd.And(bitarr2);
            Console.WriteLine(" bittArr1 And BitArrr2 : " + BitArrayToString(ResultAnd));

            BitArray ResultOr= new BitArray(bitarr1);
            ResultAnd.Or(bitarr2);
            Console.WriteLine(" bittArr1 Or BitArrr2 : " + BitArrayToString(ResultOr));


            BitArray ResultXor = new BitArray(bitarr1);
            ResultAnd.Xor(bitarr2);
            Console.WriteLine(" bittArr1 Xor BitArrr2 : " + BitArrayToString(ResultXor));

            /*
            Task 2: Parity Check
            Create a BitArray to represent an 8 - bit binary number.
            Write a function to check whether the binary number has an even or odd parity(count of true values).
            Print "Even Parity" or "Odd Parity" based on the result.         
            */
            BitArray bittArr3 = new BitArray(8);
            for(int i = 0;i < bittArr3.Count;i++)
            {
                bittArr3[i] = rnd.Next(2) == 1; 
            }
            var TrueCount = bittArr3.Cast<bool>().Where(x=>true).Count();
            Console.WriteLine(TrueCount%2==0?"Even Parity":"Odd Parity");





            /*
            Task 3: Binary Addition
            Create two BitArray objects representing binary numbers of the same length.
            Write a method to perform binary addition on the two BitArray objects.
            Handle overflow if the result exceeds the original length.
            */
            

            // Example usage
            BitArray num1 = new BitArray(new[] { true, false, true, true });
            BitArray num2 = new BitArray(new[] { true, true, false, true });
            BitArray additionResult = BinaryAddition(num1, num2);
            Console.WriteLine($"Binary Addition Result: {BitArrayToString(additionResult)}");

            /*
            Task 4: Prime Numbers Representation
            Create a BitArray of size n where each index represents whether the number is prime(true) or not (false).
            Implement the Sieve of Eratosthenes algorithm to mark all prime numbers up to n.
            Print all the indices marked as true(i.e., prime numbers).
            */
            
            // Example usage
            int max = 20;
            BitArray primeArray = SieveOfEratosthenes(max);
            Console.WriteLine($"Prime numbers up to {max}: " +
                string.Join(", ", Enumerable.Range(0, max + 1).Where(i => primeArray[i])));

            /*
            Task 5: Set Operations
            Create two BitArray objects representing sets of integers(e.g., { 0, 1, 3, 4}
                        and { 2, 3, 4, 5}).
            Perform the following operations:
            Union
            Intersection
            Symmetric Difference(elements in one set but not both)
            Print the resulting sets.
            */
            // Example sets
            BitArray set1 = new BitArray(new[] { true, false, true, true, false });
            BitArray set2 = new BitArray(new[] { false, true, true, false, true });

            BitArray union = new BitArray(set1).Or(set2);
            BitArray intersection = new BitArray(set1).And(set2);
            BitArray symmetricDifference = new BitArray(set1).Xor(set2);

            Console.WriteLine($"Union: {BitArrayToString(union)}");
            Console.WriteLine($"Intersection: {BitArrayToString(intersection)}");
            Console.WriteLine($"Symmetric Difference: {BitArrayToString(symmetricDifference)}");



            /*
            Task 6: BitArray Compression
            Write a method to compress a BitArray to a smaller representation(e.g., converting every 8 bits to a byte).
            Write another method to decompress the compressed data back to a BitArray.
            Verify the correctness by comparing the original and decompressed BitArray.
            */

           
            // Example usage
            BitArray original = new BitArray(new[] { true, false, true, true, false, true, false });
            byte[] compressed = Compress(original);
            BitArray decompressed = Decompress(compressed, original.Length);

            Console.WriteLine($"Original: {BitArrayToString(original)}");
            Console.WriteLine($"Decompressed: {BitArrayToString(decompressed)}");

            /*
            Task 7: Binary Search Simulation
            Create a BitArray representing a binary number sorted in ascending order.
            Write a method to perform a binary search on the BitArray to find a specific value(true or false).
            Print the index where the value is found, or indicate if it’s not present.
            */

           

            // Example usage
            BitArray sortedBits = new BitArray(new[] { false, false, true, true, true });
            int index = BinarySearch(sortedBits, true);
            Console.WriteLine($"Index of target 'true': {index}");


            /*
            Task 8: LINQ Queries
            Create a BitArray and initialize it with a mix of true and false values.
            Use LINQ to:
                        Count the number of true and false values.
            Find the index of the first true value.
            Find all indices where the value is true.
            Print the results.
            */

            BitArray bitArray = new BitArray(10);
            for (int i = 0; i < bitArray.Count; i++) bitArray[i] = rnd.Next(2) == 1;

            var trueCount = bitArray.Cast<bool>().Count(b => b);
            var falseCount = bitArray.Count - trueCount;
            var firstTrueIndex = bitArray.Cast<bool>().Select((b, i) => (b, i)).FirstOrDefault(x => x.b).i;
            var allTrueIndices = bitArray.Cast<bool>().Select((b, i) => (b, i)).Where(x => x.b).Select(x => x.i);

            Console.WriteLine($"True Count: {trueCount}, False Count: {falseCount}");
            Console.WriteLine($"First True Index: {firstTrueIndex}");
            Console.WriteLine($"All True Indices: {string.Join(", ", allTrueIndices)}");





            /*
            Task 9: Custom Binary Operations
            Create a BitArray of length 16 initialized with random true and false values.
            Write a method to shift all bits to the left by a specified number of positions(logical shift).
            Write another method to perform a circular shift(rotate) to the right by a specified number of positions.
            */

            static BitArray LogicalShiftLeft(BitArray bits, int positions)
            {
                for (int i = 0; i < positions; i++)
                {
                    for (int j = 0; j < bits.Count - 1; j++)
                        bits[j] = bits[j + 1];
                    bits[bits.Count - 1] = false;
                }
                return bits;
            }

            static BitArray CircularShiftRight(BitArray bits, int positions)
            {
                for (int i = 0; i < positions; i++)
                {
                    bool lastBit = bits[bits.Count - 1];
                    for (int j = bits.Count - 1; j > 0; j--)
                        bits[j] = bits[j - 1];
                    bits[0] = lastBit;
                }
                return bits;
            }


            /*
            Task 10: Gray Code Generation
            Create a method that generates n - bit Gray codes(binary codes where only one bit changes between consecutive values).
            Use a BitArray to store and manipulate the values during generation.
            Print all Gray codes for a given n.
            */

            static List<BitArray> GenerateGrayCodes(int n)
            {
                List<BitArray> grayCodes = new List<BitArray>();
                for (int i = 0; i < (1 << n); i++)
                {
                    int gray = i ^ (i >> 1);
                    grayCodes.Add(new BitArray(new[] { gray }));
                }
                return grayCodes;
            }

            // Example usage
            var grayCodes = GenerateGrayCodes(3);
            foreach (var code in grayCodes)
            {
                Console.WriteLine(BitArrayToString(code));
            }




            Console.ReadLine();
        }
        public static string BitArrayToString(BitArray bitarr)
        {
            char[]chararr = new char[bitarr.Count];

            for(int i = 0;i<chararr.Length;i++)
            {
                chararr[i] = bitarr[i]?'1':'0';
            }
            return new string(chararr);
        }
        static BitArray BinaryAddition(BitArray a, BitArray b)
        {
            BitArray result = new BitArray(a.Length);
            bool carry = false;
            for (int i = 0; i < a.Length; i++)
            {
                bool sum = a[i] ^ b[i] ^ carry;
                carry = (a[i] & b[i]) || (a[i] & carry) || (b[i] & carry);
                result[i] = sum;
            }
            return result;
        }
        static BitArray SieveOfEratosthenes(int n)
        {
            BitArray primes = new BitArray(n + 1, true);
            primes[0] = primes[1] = false;

            for (int p = 2; p * p <= n; p++)
            {
                if (primes[p])
                {
                    for (int i = p * p; i <= n; i += p)
                        primes[i] = false;
                }
            }
            return primes;
        }
        static byte[] Compress(BitArray bits)
        {
            byte[] bytes = new byte[(bits.Length + 7) / 8];
            bits.CopyTo(bytes, 0);
            return bytes;
        }

        static BitArray Decompress(byte[] bytes, int originalLength)
        {
            return new BitArray(bytes) { Length = originalLength };
        }

        static int BinarySearch(BitArray bits, bool target)
        {
            int left = 0, right = bits.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (bits[mid] == target) return mid;
                if (!bits[mid]) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}
