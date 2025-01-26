namespace Course20.TraficLight_008
{
    partial class FrmStreet
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
            ctrlTraficLight1 = new CtrlTraficLight();
            ctrlTraficLight2 = new CtrlTraficLight();
            ctrlTraficLight3 = new CtrlTraficLight();
            ctrlTraficLight4 = new CtrlTraficLight();
            pbCar = new PictureBox();
            panel1 = new Panel();
            btnMove = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            ctrlTraficLight1.CurrentLight = CtrlTraficLight.enLightColors.Orange;
            ctrlTraficLight1.GreenTime = 5;
            ctrlTraficLight1.Location = new Point(-1, 179);
            ctrlTraficLight1.Name = "ctrlTraficLight1";
            ctrlTraficLight1.OrangeTime = 2;
            ctrlTraficLight1.RedTime = 3;
            ctrlTraficLight1.Size = new Size(74, 150);
            ctrlTraficLight1.TabIndex = 0;
            // 
            // ctrlTraficLight2
            // 
            ctrlTraficLight2.CurrentLight = CtrlTraficLight.enLightColors.Green;
            ctrlTraficLight2.GreenTime = 5;
            ctrlTraficLight2.Location = new Point(408, 12);
            ctrlTraficLight2.Name = "ctrlTraficLight2";
            ctrlTraficLight2.OrangeTime = 2;
            ctrlTraficLight2.RedTime = 3;
            ctrlTraficLight2.Size = new Size(74, 147);
            ctrlTraficLight2.TabIndex = 1;
            // 
            // ctrlTraficLight3
            // 
            ctrlTraficLight3.CurrentLight = CtrlTraficLight.enLightColors.Red;
            ctrlTraficLight3.GreenTime = 5;
            ctrlTraficLight3.Location = new Point(824, 179);
            ctrlTraficLight3.Name = "ctrlTraficLight3";
            ctrlTraficLight3.OrangeTime = 2;
            ctrlTraficLight3.RedTime = 3;
            ctrlTraficLight3.Size = new Size(74, 150);
            ctrlTraficLight3.TabIndex = 2;
            // 
            // ctrlTraficLight4
            // 
            ctrlTraficLight4.CurrentLight = CtrlTraficLight.enLightColors.Red;
            ctrlTraficLight4.GreenTime = 5;
            ctrlTraficLight4.Location = new Point(408, 356);
            ctrlTraficLight4.Name = "ctrlTraficLight4";
            ctrlTraficLight4.OrangeTime = 2;
            ctrlTraficLight4.RedTime = 3;
            ctrlTraficLight4.Size = new Size(74, 150);
            ctrlTraficLight4.TabIndex = 3;
            // 
            // pbCar
            // 
            pbCar.BackColor = Color.Transparent;
            pbCar.BackgroundImageLayout = ImageLayout.Stretch;
            pbCar.Image = Properties.Resources.car;
            pbCar.Location = new Point(798, 416);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(100, 54);
            pbCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCar.TabIndex = 4;
            pbCar.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = Properties.Resources.street2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 518);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 0);
            panel1.TabIndex = 12;
            // 
            // btnMove
            // 
            btnMove.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMove.Location = new Point(366, 253);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(79, 35);
            btnMove.TabIndex = 13;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(461, 253);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 35);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmStreet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 518);
            Controls.Add(btnBack);
            Controls.Add(btnMove);
            Controls.Add(pbCar);
            Controls.Add(panel1);
            Controls.Add(ctrlTraficLight4);
            Controls.Add(ctrlTraficLight3);
            Controls.Add(ctrlTraficLight2);
            Controls.Add(ctrlTraficLight1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmStreet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Street";
            Load += FrmStreet_Load;
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CtrlTraficLight ctrlTraficLight1;
        private CtrlTraficLight ctrlTraficLight2;
        private CtrlTraficLight ctrlTraficLight3;
        private CtrlTraficLight ctrlTraficLight4;
        private PictureBox pbCar;
        private Panel panel1;
        private Button btnMove;
        private Button btnBack;
    }
}