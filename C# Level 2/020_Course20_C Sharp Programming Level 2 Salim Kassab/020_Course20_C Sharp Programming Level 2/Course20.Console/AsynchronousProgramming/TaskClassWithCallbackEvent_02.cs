/// <summary>
/// Copy Code to the Main method
/// </summary>
partial class Program
{
	public delegate void CallBackEventHandler(object sender, int htmlCharacterCount);
	public static event CallBackEventHandler callBackEvent;

	static async Task Main2()
	{
		callBackEvent += onCallBackReceived;

		Task performTask = peroformAsyncOperation(callBackEvent);

		Console.WriteLine("do other tasks...");

		await performTask;

		Console.WriteLine("Done all tasks");
	}

	static void onCallBackReceived(object sender, int htmlCharacterCount)
	{
		Console.WriteLine($"html characters count is: {htmlCharacterCount}");
	}

	static async Task peroformAsyncOperation(CallBackEventHandler callBackEventHandler)
	{
		await Task.Delay(5000);

		callBackEvent.Invoke(null, 1500);
	}
}
