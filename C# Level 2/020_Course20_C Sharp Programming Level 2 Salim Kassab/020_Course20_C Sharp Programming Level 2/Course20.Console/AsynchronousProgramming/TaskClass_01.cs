using System;

namespace Course20.Console.AsynchronousProgramming
{
	public class TaskClass_01
	{
		/// <summary>
		/// Copy Code to the Main method
		/// </summary>
		public async void main1()
		{
			Task<int> dataSizeTaskResult = getDataSize();

			System.Console.WriteLine("doing other work...");

			int dataSize = await dataSizeTaskResult;
			System.Console.WriteLine($"data size is: {dataSize}");
		}

		private async Task<int> getDataSize()
		{
			System.Console.WriteLine("getting data size from database...");
			await Task.Delay(5000);

			return 500;
		}
	}
}