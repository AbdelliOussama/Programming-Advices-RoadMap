using Course20.Properties;
using System.Drawing;

namespace Course20.MoreAboutUserControls.TraficLightProject_01.MyTrafficLight_01
{
	public partial class CtrlMyTrafficLight : UserControl
	{
		private byte _redColorTime;

		private byte _orangeColorTime;

		private byte _greenColorTime;

		private byte _countdownTimer;

		private enTrafficLightColors _currentColor;

		private enTrafficLightColors _prevColor;

		//////////////////////////// Color Completed Events ////////////////////////////

		//Red Completed
		public event Action<string> onRedCompleted;
		protected virtual void RedCompleted(string redCompletedMessage)
		{
			Action<string> handler = onRedCompleted;
			if (handler is not null)
				handler(redCompletedMessage);
		}

		//Orange Completed
		public event Action<string> onOrangeCompleted;
		protected virtual void OrangeCompleted(string orangeCompletedMessage)
		{
			Action<string> handler = onOrangeCompleted;
			if (handler is not null)
				handler(orangeCompletedMessage);
		}

		//Green Completed
		public event Action<string> onGreenCompleted;
		protected virtual void GreenCompleted(string greenCompletedMessage)
		{
			Action<string> handler = onGreenCompleted;
			if (handler is not null)
				handler(greenCompletedMessage);
		}

		///////////////////////////////////////////////////////////////

		public enum enTrafficLightColors { Red, Orange, Green }

		public CtrlMyTrafficLight()
		{
			InitializeComponent();

			_redColorTime = 2;
			_orangeColorTime = 3;
			_greenColorTime = 4;

			start(enTrafficLightColors.Red);
		}

		private void enableTimer()
		{
			timer.Interval = 1000;
			timer.Start();
			timer.Tick += tickAction;
		}

		private void changeTrafficLightProperties(Bitmap trafficLightImage, Color countDownLabelColor, byte countdownTimer, enTrafficLightColors trafficLightColor)
		{
			pbTrafficLight.Image = trafficLightImage;
			lblCountDown.ForeColor = countDownLabelColor;
			_countdownTimer = countdownTimer;
			_currentColor = trafficLightColor;
		}

		private void changeToNextColor(enTrafficLightColors nextColor) => changeTrafficLightColor(nextColor);

		private void changeTrafficLightColor(enTrafficLightColors trafficLightColor)
		{
			switch (trafficLightColor)
			{
				case enTrafficLightColors.Red:
					changeTrafficLightProperties(Resources.Red, Color.Red, _redColorTime, enTrafficLightColors.Red);
					break;

				case enTrafficLightColors.Orange:
					changeTrafficLightProperties(Resources.Orange, Color.Orange, _orangeColorTime, enTrafficLightColors.Orange);
					break;

				case enTrafficLightColors.Green:
					changeTrafficLightProperties(Resources.Green, Color.Green, _greenColorTime, enTrafficLightColors.Green);
					break;

				default:
					MessageBox.Show("Invalid Traffic Light Color");
					break;
			}
		}

		/////////////////////////////// Events  ///////////////////////////////


		/////////////////////////////// Start Here  ///////////////////////////////

		private void start(enTrafficLightColors startColor)
		{
			changeTrafficLightColor(startColor);
			enableTimer();
		}

		private void tickAction(object? sender, EventArgs e)
		{
			if (_countdownTimer < 1)
			{
				switch (_currentColor)
				{
					case enTrafficLightColors.Red:
					case enTrafficLightColors.Green:
						if (_currentColor == enTrafficLightColors.Red)
						{
							_prevColor = enTrafficLightColors.Red;

							if (onRedCompleted is not null)
								RedCompleted("Red Time is Done");
						}

						else
						{
							_prevColor = enTrafficLightColors.Green;

							if (onGreenCompleted is not null)
								GreenCompleted("Green Time is Done");
						}

						changeToNextColor(enTrafficLightColors.Orange);
						break;

					case enTrafficLightColors.Orange:
						if (_prevColor == enTrafficLightColors.Red)
							changeToNextColor(enTrafficLightColors.Green);
						else
							changeToNextColor(enTrafficLightColors.Red);

						if (onOrangeCompleted is not null)
							OrangeCompleted("Orange Time is Done");

						break;
				}
			}

			lblCountDown.Text = _countdownTimer.ToString();
			_countdownTimer--;
		}
	}
}