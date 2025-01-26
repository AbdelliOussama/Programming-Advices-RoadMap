namespace Course20.Events.TemperatureChangeEventExample_03
{
    partial class FrmThermostat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThermostat));
            pictureBox1 = new PictureBox();
            btnIncrementTemperature = new Button();
            panel1 = new Panel();
            lblTemperatureAlarmLabel = new Label();
            lblCurrentTemperature = new Label();
            label1 = new Label();
            btnDecrementTemperature = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIncrementTemperature
            // 
            btnIncrementTemperature.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncrementTemperature.Location = new Point(339, 23);
            btnIncrementTemperature.Name = "btnIncrementTemperature";
            btnIncrementTemperature.Size = new Size(75, 56);
            btnIncrementTemperature.TabIndex = 1;
            btnIncrementTemperature.Text = "+";
            btnIncrementTemperature.UseVisualStyleBackColor = true;
            btnIncrementTemperature.Click += btnIncrementTemperature_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTemperatureAlarmLabel);
            panel1.Controls.Add(lblCurrentTemperature);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(60, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 196);
            panel1.TabIndex = 2;
            // 
            // lblTemperatureAlarmLabel
            // 
            lblTemperatureAlarmLabel.AutoSize = true;
            lblTemperatureAlarmLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemperatureAlarmLabel.ForeColor = Color.Red;
            lblTemperatureAlarmLabel.Location = new Point(12, 125);
            lblTemperatureAlarmLabel.Name = "lblTemperatureAlarmLabel";
            lblTemperatureAlarmLabel.Size = new Size(184, 21);
            lblTemperatureAlarmLabel.TabIndex = 4;
            lblTemperatureAlarmLabel.Text = "Temperature Alarm Label";
            // 
            // lblCurrentTemperature
            // 
            lblCurrentTemperature.AutoSize = true;
            lblCurrentTemperature.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentTemperature.ForeColor = Color.FromArgb(0, 192, 0);
            lblCurrentTemperature.Location = new Point(29, 66);
            lblCurrentTemperature.Name = "lblCurrentTemperature";
            lblCurrentTemperature.Size = new Size(107, 37);
            lblCurrentTemperature.TabIndex = 3;
            lblCurrentTemperature.Text = "15:00 C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 3;
            label1.Text = "Current Temperature";
            // 
            // btnDecrementTemperature
            // 
            btnDecrementTemperature.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecrementTemperature.Location = new Point(339, 228);
            btnDecrementTemperature.Name = "btnDecrementTemperature";
            btnDecrementTemperature.Size = new Size(75, 56);
            btnDecrementTemperature.TabIndex = 3;
            btnDecrementTemperature.Text = "-";
            btnDecrementTemperature.UseVisualStyleBackColor = true;
            btnDecrementTemperature.Click += btnDecrementTemperature_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(339, 129);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 56);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FrmThermostat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 307);
            Controls.Add(btnReset);
            Controls.Add(btnDecrementTemperature);
            Controls.Add(panel1);
            Controls.Add(btnIncrementTemperature);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmThermostat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thermostat";
            Load += FrmThermostat_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIncrementTemperature;
        private Panel panel1;
        private Label label1;
        private Label lblCurrentTemperature;
        private Button btnDecrementTemperature;
        private Label lblTemperatureAlarmLabel;
        private Button btnReset;
    }
}