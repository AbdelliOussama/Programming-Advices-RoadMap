namespace Course20.MoreAboutUserControls.PoolClubProject_02
{
	partial class FrmReadPoolTableInfo
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
			txtPlayerName = new TextBox();
			label1 = new Label();
			label2 = new Label();
			nudHourRate = new NumericUpDown();
			btnSave = new Button();
			((System.ComponentModel.ISupportInitialize)nudHourRate).BeginInit();
			SuspendLayout();
			// 
			// txtPlayerName
			// 
			txtPlayerName.Location = new Point(104, 26);
			txtPlayerName.Name = "txtPlayerName";
			txtPlayerName.Size = new Size(152, 23);
			txtPlayerName.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 34);
			label1.Name = "label1";
			label1.Size = new Size(74, 15);
			label1.TabIndex = 1;
			label1.Text = "Player Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 83);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 3;
			label2.Text = "Hour Rate";
			// 
			// nudHourRate
			// 
			nudHourRate.Location = new Point(104, 75);
			nudHourRate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudHourRate.Name = "nudHourRate";
			nudHourRate.Size = new Size(152, 23);
			nudHourRate.TabIndex = 4;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(178, 129);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(78, 23);
			btnSave.TabIndex = 5;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// FrmReadPoolTableInfo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(283, 167);
			Controls.Add(btnSave);
			Controls.Add(nudHourRate);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPlayerName);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "FrmReadPoolTableInfo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Read Table Info";
			((System.ComponentModel.ISupportInitialize)nudHourRate).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtPlayerName;
		private Label label1;
		private Label label2;
		private NumericUpDown nudHourRate;
		private Button btnSave;
	}
}