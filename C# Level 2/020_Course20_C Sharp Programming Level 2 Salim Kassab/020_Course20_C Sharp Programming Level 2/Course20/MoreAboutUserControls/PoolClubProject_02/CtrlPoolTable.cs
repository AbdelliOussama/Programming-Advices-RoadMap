namespace Course20.MoreAboutUserControls.PoolClubProject_02
{
	public partial class CtrlPoolTable : UserControl
	{
		private double _hourRate;
		private int _secondsCounter;
		private bool _isStart = true;

		//////////////////////// Event //////////////////////
		public event Action<int, double, double> onGameOver;
		protected virtual void GameOver(int secondsCounter, double hourRate, double totalFees)
		{
			Action<int, double, double> handler = onGameOver;
			if (handler is not null)
				handler(secondsCounter, hourRate, totalFees);
		}
		////////////////////////////////////////////////////

		public CtrlPoolTable()
		{
			InitializeComponent();
			configureTimer();
		}

		private void configureTimer()
		{
			timer.Interval = 1000;
			timer.Tick += tickAction;
		}

		private void tickAction(object? sender, EventArgs e)
		{
			_secondsCounter++;
			lblSeconds.Text = $"{_secondsCounter} Sec";
		}

		private void readPoolTableInfo(object sender, string playerName, double hourRate)
		{
			_hourRate = hourRate;
			lblPlayerName.Text = playerName;
			lblHourRate.Text = $"{hourRate}$";
		}

		private void resetTable()
		{
			_isStart = true;
			_secondsCounter = 0;
			lblPlayerName.Text = "??";
			lblHourRate.Text = "??";
			lblSeconds.Text = "0";
			btnStart.Text = "Start";
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (_isStart)
			{
				FrmReadPoolTableInfo frm = new();
				frm.DataBack += readPoolTableInfo;
				frm.ShowDialog();
				_isStart = false;
			}

			if (btnStart.Text == "Start")
			{
				timer.Start();
				btnStart.Text = "Stop";
			}
			else
			{
				timer.Stop();
				btnStart.Text = "Start";
			}
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			timer.Stop();

			if (onGameOver is not null)
				GameOver(_secondsCounter, _hourRate, _secondsCounter * _hourRate / 3600);

			resetTable();
		}
	}
}