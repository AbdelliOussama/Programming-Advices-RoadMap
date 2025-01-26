namespace Course20.MoreAboutUserControls.PoolClubProject_02
{
	public partial class FrmReadPoolTableInfo : Form
	{
		/////////////////// Event //////////////////////
		public delegate void DataBackEventHandler(object sender, string playerName, double hourRate);
		public event DataBackEventHandler DataBack;
		///////////////////////////////////////////////

		public FrmReadPoolTableInfo() => InitializeComponent();

		private void btnSave_Click(object sender, EventArgs e)
		{
			string playerName = txtPlayerName.Text;
			double hourRate = double.Parse(nudHourRate.Value.ToString());

			DataBack.Invoke(this, playerName, hourRate);
			this.Close();
		}
	}
}
