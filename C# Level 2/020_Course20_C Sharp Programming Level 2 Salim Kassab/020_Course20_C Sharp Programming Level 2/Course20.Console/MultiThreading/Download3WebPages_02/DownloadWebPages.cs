using System;
using System.Net;

namespace Course20.Console.MultiThreading.Download3WebPages
{
	public class DownloadWebPages
	{
		public void main()
		{
			System.Console.WriteLine("Starting Threads");

			Thread t1 = new(() => downloadAndPrint("https://www.Amazon.com"));
			t1.Start();
			System.Console.WriteLine("Thread1 Started");

			Thread t2 = new(() => downloadAndPrint("https://www.Google.com"));
			t2.Start();
			System.Console.WriteLine("Thread2 Started");

			Thread t3 = new(() => downloadAndPrint("https://www.ProgrammingAdvices.com"));
			t3.Start();
			System.Console.WriteLine("Thread3 Started");

			t1.Join();
			t2.Join();
			t3.Join();

			System.Console.WriteLine("Done for all Threads");
		}

		public void downloadAndPrint(string url)
		{
			string content;

			using (WebClient client = new())
			{
				Thread.Sleep(100);
				content = client.DownloadString(url);
			}

			System.Console.WriteLine($"{url}: {content.Length} characters downloaded");
		}
	}
}
