using MyNameSpace;
using System.Reflection;

namespace Course20.Console.Reflection_Example_2_003
{
    internal class SolveExercise
    {
        public Type myClassType = typeof(MyClass);



        private static string GetParameterList(ParameterInfo[] parameters) => string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));

        public string getTypeName_01() => myClassType.Name;

        public string getFullName_02() => myClassType.FullName;
         
        public void printMyClassProperties_03()
        {
            foreach (var property in myClassType.GetProperties())
                System.Console.WriteLine($"property name: {property.Name},  type: {property.PropertyType}");
        }

        public void printMyClassPropertiesMethods_04()
        {
            foreach (var method in myClassType.GetMethods())
                System.Console.WriteLine($"{method.ReturnType} {method.Name}({GetParameterList(method.GetParameters())})");
        }

        public object createObjectUsingReflection_05() => Activator.CreateInstance(myClassType);

        public void setProperty1UsingReflection_06(object obj, int value) => myClassType.GetProperty("Property1").SetValue(obj, value);
    }
}