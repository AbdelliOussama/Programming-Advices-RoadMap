namespace Course20.MoreAboutUserControls.TraficLightProject_01.MyTrafficLight_01
{
	partial class CtrlMyTrafficLight
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
			pbTrafficLight = new PictureBox();
			lblCountDown = new Label();
			timer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)pbTrafficLight).BeginInit();
			SuspendLayout();
			// 
			// pbTrafficLight
			// 
			pbTrafficLight.Location = new Point(3, 3);
			pbTrafficLight.Name = "pbTrafficLight";
			pbTrafficLight.Size = new Size(69, 108);
			pbTrafficLight.SizeMode = PictureBoxSizeMode.Zoom;
			pbTrafficLight.TabIndex = 0;
			pbTrafficLight.TabStop = false;
			// 
			// lblCountDown
			// 
			lblCountDown.AutoSize = true;
			lblCountDown.Location = new Point(29, 123);
			lblCountDown.Name = "lblCountDown";
			lblCountDown.Size = new Size(17, 15);
			lblCountDown.TabIndex = 1;
			lblCountDown.Text = "??";
			// 
			// timer
			// 
			timer.Interval = 1000;
			// 
			// CtrlMyTrafficLight
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblCountDown);
			Controls.Add(pbTrafficLight);
			Name = "CtrlMyTrafficLight";
			Size = new Size(75, 147);
			((System.ComponentModel.ISupportInitialize)pbTrafficLight).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pbTrafficLight;
		private Label lblCountDown;
		private System.Windows.Forms.Timer timer;
	}
}
