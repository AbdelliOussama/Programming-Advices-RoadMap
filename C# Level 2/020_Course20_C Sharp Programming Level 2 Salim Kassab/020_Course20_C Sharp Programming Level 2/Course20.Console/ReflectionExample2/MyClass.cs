namespace MyNameSpace
{
    public class MyClass
    {
        public int Property1 { get; set; }

        public void method1() => Console.WriteLine("method1 executed");
        public void method2(int value1, string value2) => Console.WriteLine($"method2 executed, value1: {value1}, value2: {value2}");
    }
}