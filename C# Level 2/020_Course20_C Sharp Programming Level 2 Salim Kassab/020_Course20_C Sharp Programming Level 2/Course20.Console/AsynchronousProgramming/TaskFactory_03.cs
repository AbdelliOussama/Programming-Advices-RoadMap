partial class Program
{
	/// <summary>
	/// Copy Code to the Main method
	/// </summary>
	static async Task Main3()
	{
		CancellationTokenSource cts = new();
		CancellationToken token = cts.Token;

		TaskFactory taskFactory = new(
			token,
			TaskCreationOptions.AttachedToParent,
			TaskContinuationOptions.ExecuteSynchronously,
			TaskScheduler.Default);

		Task task1 = taskFactory.StartNew(() =>
		{
			Console.WriteLine("Task 1 is running ");
			Thread.Sleep(3000);
			Console.WriteLine("Task 1 completed");
		});

		Task task2 = taskFactory.StartNew(() =>
		{
			Console.WriteLine("Task 2 is running ");
			Thread.Sleep(3000);
			Console.WriteLine("Task 2 completed");
		});
	}
}