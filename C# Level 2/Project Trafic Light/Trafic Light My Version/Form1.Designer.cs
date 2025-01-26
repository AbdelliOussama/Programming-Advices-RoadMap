namespace Trafic_Light_My_Version
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlTraficLight4 = new Trafic_Light_My_Version.ctrlTraficLight();
            this.ctrlTraficLight3 = new Trafic_Light_My_Version.ctrlTraficLight();
            this.ctrlTraficLight2 = new Trafic_Light_My_Version.ctrlTraficLight();
            this.ctrlTraficLight1 = new Trafic_Light_My_Version.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight4
            // 
            this.ctrlTraficLight4.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight4.CurrentLightColor = Trafic_Light_My_Version.ctrlTraficLight.enTraficLightColor.green;
            this.ctrlTraficLight4.GreenLightTime = 10;
            this.ctrlTraficLight4.Location = new System.Drawing.Point(12, 286);
            this.ctrlTraficLight4.Name = "ctrlTraficLight4";
            this.ctrlTraficLight4.RedLightTime = 10;
            this.ctrlTraficLight4.Size = new System.Drawing.Size(115, 237);
            this.ctrlTraficLight4.TabIndex = 3;
            this.ctrlTraficLight4.YellowLightTime = 5;
            // 
            // ctrlTraficLight3
            // 
            this.ctrlTraficLight3.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight3.CurrentLightColor = Trafic_Light_My_Version.ctrlTraficLight.enTraficLightColor.green;
            this.ctrlTraficLight3.GreenLightTime = 10;
            this.ctrlTraficLight3.Location = new System.Drawing.Point(789, 234);
            this.ctrlTraficLight3.Name = "ctrlTraficLight3";
            this.ctrlTraficLight3.RedLightTime = 10;
            this.ctrlTraficLight3.Size = new System.Drawing.Size(115, 237);
            this.ctrlTraficLight3.TabIndex = 2;
            this.ctrlTraficLight3.YellowLightTime = 5;
            // 
            // ctrlTraficLight2
            // 
            this.ctrlTraficLight2.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight2.CurrentLightColor = Trafic_Light_My_Version.ctrlTraficLight.enTraficLightColor.yellow;
            this.ctrlTraficLight2.GreenLightTime = 10;
            this.ctrlTraficLight2.Location = new System.Drawing.Point(789, 12);
            this.ctrlTraficLight2.Name = "ctrlTraficLight2";
            this.ctrlTraficLight2.RedLightTime = 10;
            this.ctrlTraficLight2.Size = new System.Drawing.Size(115, 237);
            this.ctrlTraficLight2.TabIndex = 1;
            this.ctrlTraficLight2.YellowLightTime = 5;
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight1.CurrentLightColor = Trafic_Light_My_Version.ctrlTraficLight.enTraficLightColor.red;
            this.ctrlTraficLight1.GreenLightTime = 10;
            this.ctrlTraficLight1.Location = new System.Drawing.Point(12, 12);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.RedLightTime = 10;
            this.ctrlTraficLight1.Size = new System.Drawing.Size(115, 237);
            this.ctrlTraficLight1.TabIndex = 0;
            this.ctrlTraficLight1.YellowLightTime = 5;
            this.ctrlTraficLight1.RedLightOn += new System.EventHandler<Trafic_Light_My_Version.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_RedLightOn);
            this.ctrlTraficLight1.YellowLightOn += new System.EventHandler<Trafic_Light_My_Version.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_YellowLightOn);
            this.ctrlTraficLight1.GreenLightOn += new System.EventHandler<Trafic_Light_My_Version.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_GreenLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Trafic_Light_My_Version.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 535);
            this.Controls.Add(this.ctrlTraficLight4);
            this.Controls.Add(this.ctrlTraficLight3);
            this.Controls.Add(this.ctrlTraficLight2);
            this.Controls.Add(this.ctrlTraficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
        private ctrlTraficLight ctrlTraficLight2;
        private ctrlTraficLight ctrlTraficLight3;
        private ctrlTraficLight ctrlTraficLight4;
    }
}

