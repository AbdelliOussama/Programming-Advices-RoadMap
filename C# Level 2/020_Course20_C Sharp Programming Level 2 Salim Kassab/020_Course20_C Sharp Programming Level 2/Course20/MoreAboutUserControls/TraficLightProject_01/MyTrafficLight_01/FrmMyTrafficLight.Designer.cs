namespace Course20.MoreAboutUserControls.TraficLightProject_01.MyTrafficLight_01
{
	partial class FrmMyTrafficLight
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
			ctrlMyTrafficLight2 = new CtrlMyTrafficLight();
			SuspendLayout();
			// 
			// ctrlMyTrafficLight2
			// 
			ctrlMyTrafficLight2.Location = new Point(12, 12);
			ctrlMyTrafficLight2.Name = "ctrlMyTrafficLight2";
			ctrlMyTrafficLight2.Size = new Size(75, 147);
			ctrlMyTrafficLight2.TabIndex = 0;
			ctrlMyTrafficLight2.onRedCompleted += ctrlMyTrafficLight2_onRedCompleted;
			ctrlMyTrafficLight2.onOrangeCompleted += ctrlMyTrafficLight2_onOrangeCompleted;
			ctrlMyTrafficLight2.onGreenCompleted += ctrlMyTrafficLight2_onGreenCompleted;
			// 
			// FrmMyTrafficLight
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(124, 170);
			Controls.Add(ctrlMyTrafficLight2);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "FrmMyTrafficLight";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "My Traffic Light";
			ResumeLayout(false);
		}

		#endregion

		private CtrlMyTrafficLight ctrlMyTrafficLight1;
		private CtrlMyTrafficLight ctrlMyTrafficLight2;
	}
}