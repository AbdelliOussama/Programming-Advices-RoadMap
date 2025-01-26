namespace Course20.MoreAboutUserControls.PoolClubProject_02
{
	partial class FrmPoolClub
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ctrlPoolTable1 = new CtrlPoolTable();
			ctrlPoolTable2 = new CtrlPoolTable();
			ctrlPoolTable3 = new CtrlPoolTable();
			ctrlPoolTable4 = new CtrlPoolTable();
			ctrlPoolTable5 = new CtrlPoolTable();
			ctrlPoolTable6 = new CtrlPoolTable();
			SuspendLayout();
			// 
			// ctrlPoolTable1
			// 
			ctrlPoolTable1.Location = new Point(12, 12);
			ctrlPoolTable1.Name = "ctrlPoolTable1";
			ctrlPoolTable1.Size = new Size(333, 242);
			ctrlPoolTable1.TabIndex = 0;
			ctrlPoolTable1.onGameOver += ctrlPoolTable1_onGameOver;
			// 
			// ctrlPoolTable2
			// 
			ctrlPoolTable2.Location = new Point(371, 12);
			ctrlPoolTable2.Name = "ctrlPoolTable2";
			ctrlPoolTable2.Size = new Size(333, 242);
			ctrlPoolTable2.TabIndex = 1;
			ctrlPoolTable2.onGameOver += ctrlPoolTable2_onGameOver;
			// 
			// ctrlPoolTable3
			// 
			ctrlPoolTable3.Location = new Point(733, 12);
			ctrlPoolTable3.Name = "ctrlPoolTable3";
			ctrlPoolTable3.Size = new Size(333, 242);
			ctrlPoolTable3.TabIndex = 2;
			ctrlPoolTable3.onGameOver += ctrlPoolTable3_onGameOver;
			// 
			// ctrlPoolTable4
			// 
			ctrlPoolTable4.Location = new Point(12, 260);
			ctrlPoolTable4.Name = "ctrlPoolTable4";
			ctrlPoolTable4.Size = new Size(333, 242);
			ctrlPoolTable4.TabIndex = 0;
			ctrlPoolTable4.onGameOver += ctrlPoolTable4_onGameOver;
			// 
			// ctrlPoolTable5
			// 
			ctrlPoolTable5.Location = new Point(371, 260);
			ctrlPoolTable5.Name = "ctrlPoolTable5";
			ctrlPoolTable5.Size = new Size(333, 242);
			ctrlPoolTable5.TabIndex = 1;
			ctrlPoolTable5.onGameOver += ctrlPoolTable5_onGameOver;
			// 
			// ctrlPoolTable6
			// 
			ctrlPoolTable6.Location = new Point(733, 260);
			ctrlPoolTable6.Name = "ctrlPoolTable6";
			ctrlPoolTable6.Size = new Size(333, 242);
			ctrlPoolTable6.TabIndex = 2;
			ctrlPoolTable6.onGameOver += ctrlPoolTable6_onGameOver;
			// 
			// FrmPoolClub
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(1098, 518);
			Controls.Add(ctrlPoolTable6);
			Controls.Add(ctrlPoolTable3);
			Controls.Add(ctrlPoolTable5);
			Controls.Add(ctrlPoolTable4);
			Controls.Add(ctrlPoolTable2);
			Controls.Add(ctrlPoolTable1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "FrmPoolClub";
			Text = "Pool Club";
			ResumeLayout(false);
		}

		#endregion

		private CtrlPoolTable ctrlPoolTable1;
		private CtrlPoolTable ctrlPoolTable2;
		private CtrlPoolTable ctrlPoolTable3;
		private CtrlPoolTable ctrlPoolTable4;
		private CtrlPoolTable ctrlPoolTable5;
		private CtrlPoolTable ctrlPoolTable6;
	}
}