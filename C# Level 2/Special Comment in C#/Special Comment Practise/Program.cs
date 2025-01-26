using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Comment_Practise
{
    internal class Program
    {

        /// <summary>
        /// This class performs mathematical operations.
        /// </summary>
        public class Calculator
        {
            /// <summary>
            /// Adds two numbers together.
            /// </summary>
            /// <param name="a">The first number.</param>
            /// <param name="b">The second number.</param>
            /// <returns>The sum of the two numbers.</returns>
            public int Add(int a, int b)
            {
                return a + b;
            }

            /// <summary>
            /// Subtracts the second number from the first.
            /// </summary>
            /// <param name="a">The first number.</param>
            /// <param name="b">The second number.</param>
            /// <returns>The result of the subtraction.</returns>
            public int Subtract(int a, int b)
            {
                return a - b;
            }


            public void CalculateTotal()
            {
                // TODO: Implement discount calculation
                double total = 100;

                // Placeholder for discount logic
                Console.WriteLine("Total: " + total);
            }


            public void ProcessData()
            {
                // HACK: This method is too slow but works for now
                Console.WriteLine("Processing data...");
            }


            public void RemoveFeature()
            {
                // UNDONE: Removed the logging feature
                Console.WriteLine("Feature removed.");
            }
            public int CalculateValue()
            {
                //FIXME: This calculation is incorrect for negative numbers
                return 10;
            }

            #region Public Methods
            public void Method1() { }
            public void Method2() { }
            #endregion

        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.CalculateTotal();
            calculator.ProcessData();

            Console.ReadKey();
        }
    }
}
