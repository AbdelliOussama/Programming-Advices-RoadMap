partial class Program
{
	static void Main6()
	{
		Parallel.Invoke(function1, function2, function3);
	}

	static void function1() => Console.WriteLine("function1");
	static void function2() => Console.WriteLine("function2");
	static void function3() => Console.WriteLine("function3");
}
