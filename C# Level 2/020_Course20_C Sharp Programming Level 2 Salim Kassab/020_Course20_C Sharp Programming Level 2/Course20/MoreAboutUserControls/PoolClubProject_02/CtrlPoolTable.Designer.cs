namespace Course20.MoreAboutUserControls.PoolClubProject_02
{
	partial class CtrlPoolTable
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPoolTable));
			gbPoolTable = new GroupBox();
			lblHourRate = new Label();
			label3 = new Label();
			label2 = new Label();
			lblPlayerName = new Label();
			lblSeconds = new Label();
			btnEnd = new Button();
			pictureBox1 = new PictureBox();
			btnStart = new Button();
			timer = new System.Windows.Forms.Timer(components);
			gbPoolTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// gbPoolTable
			// 
			gbPoolTable.BackColor = SystemColors.ControlLight;
			gbPoolTable.Controls.Add(lblHourRate);
			gbPoolTable.Controls.Add(label3);
			gbPoolTable.Controls.Add(label2);
			gbPoolTable.Controls.Add(lblPlayerName);
			gbPoolTable.Controls.Add(lblSeconds);
			gbPoolTable.Controls.Add(btnEnd);
			gbPoolTable.Controls.Add(pictureBox1);
			gbPoolTable.Controls.Add(btnStart);
			gbPoolTable.Location = new Point(3, 3);
			gbPoolTable.Name = "gbPoolTable";
			gbPoolTable.Size = new Size(324, 232);
			gbPoolTable.TabIndex = 0;
			gbPoolTable.TabStop = false;
			// 
			// lblHourRate
			// 
			lblHourRate.AutoSize = true;
			lblHourRate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblHourRate.Location = new Point(102, 45);
			lblHourRate.Name = "lblHourRate";
			lblHourRate.Size = new Size(31, 21);
			lblHourRate.TabIndex = 7;
			lblHourRate.Text = "???";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(6, 45);
			label3.Name = "label3";
			label3.Size = new Size(90, 21);
			label3.TabIndex = 6;
			label3.Text = "Hour Rate:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(6, 19);
			label2.Name = "label2";
			label2.Size = new Size(112, 21);
			label2.TabIndex = 5;
			label2.Text = "Player Name:";
			// 
			// lblPlayerName
			// 
			lblPlayerName.AutoSize = true;
			lblPlayerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPlayerName.Location = new Point(124, 19);
			lblPlayerName.Name = "lblPlayerName";
			lblPlayerName.Size = new Size(31, 21);
			lblPlayerName.TabIndex = 4;
			lblPlayerName.Text = "???";
			// 
			// lblSeconds
			// 
			lblSeconds.AutoSize = true;
			lblSeconds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSeconds.ForeColor = Color.Red;
			lblSeconds.Location = new Point(236, 127);
			lblSeconds.Name = "lblSeconds";
			lblSeconds.Size = new Size(24, 21);
			lblSeconds.TabIndex = 3;
			lblSeconds.Text = "??";
			// 
			// btnEnd
			// 
			btnEnd.Location = new Point(236, 192);
			btnEnd.Name = "btnEnd";
			btnEnd.Size = new Size(75, 23);
			btnEnd.TabIndex = 2;
			btnEnd.Text = "End";
			btnEnd.UseVisualStyleBackColor = true;
			btnEnd.Click += btnEnd_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(6, 69);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(211, 146);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// btnStart
			// 
			btnStart.Location = new Point(236, 69);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(75, 23);
			btnStart.TabIndex = 0;
			btnStart.Text = "Start";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// CtrlPoolTable
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(gbPoolTable);
			Name = "CtrlPoolTable";
			Size = new Size(333, 242);
			gbPoolTable.ResumeLayout(false);
			gbPoolTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbPoolTable;
		private Button btnStart;
		private PictureBox pictureBox1;
		private Button btnEnd;
		private Label lblSeconds;
		private Label lblPlayerName;
		private Label label2;
		private System.Windows.Forms.Timer timer;
		private Label lblHourRate;
		private Label label3;
	}
}
