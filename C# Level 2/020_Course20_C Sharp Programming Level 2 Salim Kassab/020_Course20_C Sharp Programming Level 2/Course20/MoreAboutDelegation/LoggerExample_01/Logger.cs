namespace Course20.MoreAboutDelegation.LoggerExample_01
{
	public class Logger
	{
		public delegate void logAction(string errorMessage);
		private logAction _logAction;

		public Logger(logAction logAction) => _logAction = logAction;

		public void log(string errorMessage) => _logAction(errorMessage);
	}
}