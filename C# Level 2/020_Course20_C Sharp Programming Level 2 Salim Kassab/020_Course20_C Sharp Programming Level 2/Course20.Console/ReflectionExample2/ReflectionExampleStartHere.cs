namespace Course20.Console.Reflection_Example_2_003
{
    internal class ReflectionExampleStartHere
    {
        public ReflectionExampleStartHere() => startHere();
        
        private void startHere()
        {
            SolveExercise solveExercise = new();
            System.Console.WriteLine($"type name: {solveExercise.getTypeName_01()}");
            System.Console.WriteLine($"full name: {solveExercise.getTypeName_01()}");

            System.Console.WriteLine();
            System.Console.WriteLine("MyClass Properties:");
            System.Console.WriteLine("____________________");

            solveExercise.printMyClassProperties_03();

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();


            System.Console.WriteLine("MyClass Methods:");
            System.Console.WriteLine("____________________");
            solveExercise.printMyClassPropertiesMethods_04();



            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();


            System.Console.WriteLine("Create Instance using reflection:");
            System.Console.WriteLine("____________________");
            object myClassInstance = solveExercise.createObjectUsingReflection_05();
            System.Console.WriteLine($"The object myClassInstance created successfully using reflection");



            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("set property1 to 42 using reflection");
            System.Console.WriteLine("____________________");
            solveExercise.setProperty1UsingReflection_06(myClassInstance, 42);



            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("get property1 value using reflection");
            System.Console.WriteLine("____________________");
            int property1Value = (int)solveExercise.myClassType.GetProperty("Property1").GetValue(myClassInstance);
            System.Console.WriteLine($"property1 value is: {property1Value}");


            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("executing method1 using reflection");
            System.Console.WriteLine("____________________");
            solveExercise.myClassType.GetMethod("method1").Invoke(myClassInstance, null);


            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("executing method2 with parameters using reflection");
            System.Console.WriteLine("____________________");
            object[] method2Parameters = { 100, "saleem" };
            solveExercise.myClassType.GetMethod("method2").Invoke(myClassInstance, method2Parameters);

        }
    }
}