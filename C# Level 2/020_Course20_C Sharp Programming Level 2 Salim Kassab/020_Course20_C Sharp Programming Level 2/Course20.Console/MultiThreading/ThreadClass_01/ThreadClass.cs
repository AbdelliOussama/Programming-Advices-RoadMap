using System;

namespace Course20.Console.MultiThreading.ThreadClass
{
	public class ThreadClass
	{
		public void main()
		{
			Thread thread = new(method1);
			thread.Start();

			for (int i = 10; i <= 20; i++)
				System.Console.WriteLine($"main method: {i}");
		}

		private void method1()
		{
			for (int i = 1; i < 10; i++)
				System.Console.WriteLine($"method1: {i}");
		}
	}
}