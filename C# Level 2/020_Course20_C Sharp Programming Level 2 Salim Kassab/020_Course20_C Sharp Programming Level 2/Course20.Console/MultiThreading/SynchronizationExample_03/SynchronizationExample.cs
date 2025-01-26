namespace Course20.Console.MultiThreading.SynchronizationExample_03
{
	public class SynchronizationExample
	{
		int counter = 0;
		static object lockObject = new();

		public void main()
		{
			Thread t1 = new(() => incrementCounter());
			t1.Start();

			Thread t2 = new(() => incrementCounter());
			t2.Start();


			t1.Join();
			t2.Join();

			System.Console.WriteLine(counter);
		}

		public void incrementCounter()
		{
			for (int i = 1; i < 100; i++)
				lock (lockObject)
					counter++;
		}
	}
}
