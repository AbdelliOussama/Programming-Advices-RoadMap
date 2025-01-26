using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course20.MoreAboutUserControls.PoolClubProject_02
{
	public partial class FrmPoolClub : Form
	{
		public FrmPoolClub()
		{
			InitializeComponent();
		}

		private void ctrlPoolTable1_onGameOver(int secondsCounter, double hourRate, double totalFees)
		{
			MessageBox.Show($"Seconds Consumed: {secondsCounter} Sec\n Hour Rate: {hourRate}$\n Total Fees: {secondsCounter * hourRate / 3600:0.00}$", "Game Over");
		}

		private void ctrlPoolTable2_onGameOver(int secondsCounter, double hourRate, double totalFees)
		{
			MessageBox.Show($"Seconds Consumed: {secondsCounter} Sec\n Hour Rate: {hourRate}$\n Total Fees: {secondsCounter * hourRate / 3600:0.00}$", "Game Over");
		}

		private void ctrlPoolTable3_onGameOver(int secondsCounter, double hourRate, double totalFees)
		{
			MessageBox.Show($"Seconds Consumed: {secondsCounter} Sec\n Hour Rate: {hourRate}$\n Total Fees: {secondsCounter * hourRate / 3600:0.00}$", "Game Over");
		}

		private void ctrlPoolTable4_onGameOver(int secondsCounter, double hourRate, double totalFees)
		{
			MessageBox.Show($"Seconds Consumed: {secondsCounter} Sec\n Hour Rate: {hourRate}$\n Total Fees: {secondsCounter * hourRate / 3600:0.00}$", "Game Over");
		}

		private void ctrlPoolTable5_onGameOver(int secondsCounter, double hourRate, double totalFees)
		{
			MessageBox.Show($"Seconds Consumed: {secondsCounter} Sec\n Hour Rate: {hourRate}$\n Total Fees: {secondsCounter * hourRate / 3600:0.00}$", "Game Over");
		}

		private void ctrlPoolTable6_onGameOver(int secondsCounter, double hourRate, double totalFees)
		{
			MessageBox.Show($"Seconds Consumed: {secondsCounter} Sec\n Hour Rate: {hourRate}$\n Total Fees: {secondsCounter * hourRate / 3600:0.00}$", "Game Over");
		}
	}
}
