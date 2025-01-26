using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace ReflectionPractise
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Type myType = typeof(string);

            PropertyInfo[] propertyInfos = myType.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.Name);
            }

            MethodInfo[] methodInfos = myType.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
                Console.WriteLine(methodInfo.ReturnType);
                Console.WriteLine(methodInfo.GetParameters());
            }


            Console.WriteLine(myType.Name);
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.IsValueType);
            Console.WriteLine(myType.IsClass);
            
            Console.ReadKey();
        }
    }
}
