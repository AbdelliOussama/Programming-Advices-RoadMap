using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomAttribute_Practise
{

    internal class Program
    {

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        class MyCustomAttribute : Attribute
        {
            public string Description { get; }

            public MyCustomAttribute(string description)
            { this.Description = description; }
        }

        [MyCustom("This Clss is a Calculator Class It is Used To Dill With Simple Operation Like Adding Substraction and Division")]
        public class Calculator
        {
            [MyCustom("this Method is Used To Add To Integer")]
            public void Add(int a, int b)
            {
                Console.WriteLine($"The Sum Of {a} and {b} = {a + b} ");
            }

            [MyCustom("this Method is Used To Substracte To Integer")]
            public void Substracte(int a, int b)
            {
                Console.WriteLine($"The Substraction Of {a} and {b} = {a - b} ");
            }

            [MyCustom("this Method is Used To Multiply To Integer")]
            public void Multiply(int a, int b)
            {
                Console.WriteLine($"The Multiplication  Of {a} and {b} = {a * b} ");
            }

            [MyCustom("this Method is Used To Divide To Integer")]
            public void Divide (int a, int b)
            {
                Console.WriteLine($"The Division Of {a} and {b} = {a + b} ");
            }


        }
        static void Main(string[] args)
        {
            Type type = typeof(Calculator);

            object[] ClassAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), true);

            foreach(MyCustomAttribute attribute in ClassAttributes)
            {
                Console.WriteLine(" Class Attribute : "+attribute.Description);
            }

            MethodInfo methodinfo1 = type.GetMethod("Add");
            object[] MethodAttributes = methodinfo1.GetCustomAttributes(typeof(MyCustomAttribute), true);
            foreach(MyCustomAttribute Methodattribute in MethodAttributes)
            {
                Console.WriteLine("Method Attribute : "+Methodattribute.Description);
            }


            MethodInfo methodinfo2 = type.GetMethod("Substracte");
            object[] MethodAttributes2 = methodinfo2.GetCustomAttributes(typeof(MyCustomAttribute), true);
            foreach (MyCustomAttribute Methodattribute in MethodAttributes2)
            {
                Console.WriteLine("Method Attribute : " + Methodattribute.Description);
            }


            Console.ReadKey();
        }
    }
}
