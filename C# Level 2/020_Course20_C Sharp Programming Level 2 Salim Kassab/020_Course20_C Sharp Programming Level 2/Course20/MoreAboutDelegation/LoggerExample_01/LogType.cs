namespace Course20.MoreAboutDelegation.LoggerExample_01
{
	public static class LogType
	{
		public static void onScreen(string errorMessage) => MessageBox.Show(errorMessage, "Error Message");

		public static void toFile(string errorMessage)
		{
			string fileName = "log.txt";

			using StreamWriter writer = new(fileName, true);
			writer.WriteLine(errorMessage);
		}
	}
}
