partial class Program
{
	static void Main4()
	{
		int numberOfIterations = 10;

		Parallel.For(0, numberOfIterations, i =>
		{
			Console.WriteLine($"saleem {i} on Thread Id: {Task.CurrentId}");
			Thread.Sleep(5000);
		});

		Console.WriteLine();
		Console.WriteLine("=== without tread ===");
		Console.WriteLine();

		for (int i = 0; i < numberOfIterations; i++)
		{
			Console.WriteLine($"saleem {i} on Thread Id: {Task.CurrentId}");
			Thread.Sleep(5000);
		}
	}
}
