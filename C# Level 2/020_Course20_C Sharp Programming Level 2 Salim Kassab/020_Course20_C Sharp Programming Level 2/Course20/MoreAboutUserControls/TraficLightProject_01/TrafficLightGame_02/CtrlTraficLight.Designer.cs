namespace Course20.TraficLight_008
{
    partial class CtrlTraficLight
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
            pbLight = new PictureBox();
            lblCountDown = new Label();
            lightTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbLight).BeginInit();
            SuspendLayout();
            // 
            // pbLight
            // 
            pbLight.Image = Properties.Resources.Red;
            pbLight.Location = new Point(3, 3);
            pbLight.Name = "pbLight";
            pbLight.Size = new Size(68, 121);
            pbLight.SizeMode = PictureBoxSizeMode.Zoom;
            pbLight.TabIndex = 0;
            pbLight.TabStop = false;
            // 
            // lblCountDown
            // 
            lblCountDown.AutoSize = true;
            lblCountDown.Location = new Point(29, 127);
            lblCountDown.Name = "lblCountDown";
            lblCountDown.Size = new Size(17, 15);
            lblCountDown.TabIndex = 1;
            lblCountDown.Text = "??";
            // 
            // lightTimer
            // 
            lightTimer.Interval = 1000;
            lightTimer.Tick += lightTimer_Tick;
            // 
            // CtrlTraficLight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCountDown);
            Controls.Add(pbLight);
            Name = "CtrlTraficLight";
            Size = new Size(74, 150);
            ((System.ComponentModel.ISupportInitialize)pbLight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLight;
        private Label lblCountDown;
        private System.Windows.Forms.Timer lightTimer;
    }
}
