namespace Trafic_Light_My_Version
{
    partial class ctrlTraficLight
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbTraficLight = new System.Windows.Forms.PictureBox();
            this.lblCounterDown = new System.Windows.Forms.Label();
            this.TraficLightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTraficLight
            // 
            this.pbTraficLight.Image = global::Trafic_Light_My_Version.Properties.Resources.Red;
            this.pbTraficLight.Location = new System.Drawing.Point(3, 3);
            this.pbTraficLight.Name = "pbTraficLight";
            this.pbTraficLight.Size = new System.Drawing.Size(109, 169);
            this.pbTraficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraficLight.TabIndex = 0;
            this.pbTraficLight.TabStop = false;
            // 
            // lblCounterDown
            // 
            this.lblCounterDown.AutoSize = true;
            this.lblCounterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterDown.ForeColor = System.Drawing.Color.Red;
            this.lblCounterDown.Location = new System.Drawing.Point(36, 193);
            this.lblCounterDown.Name = "lblCounterDown";
            this.lblCounterDown.Size = new System.Drawing.Size(39, 29);
            this.lblCounterDown.TabIndex = 1;
            this.lblCounterDown.Text = "??";
            // 
            // TraficLightTimer
            // 
            this.TraficLightTimer.Tick += new System.EventHandler(this.TraficLightTimer_Tick);
            // 
            // ctrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCounterDown);
            this.Controls.Add(this.pbTraficLight);
            this.Name = "ctrlTraficLight";
            this.Size = new System.Drawing.Size(115, 237);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTraficLight;
        private System.Windows.Forms.Label lblCounterDown;
        private System.Windows.Forms.Timer TraficLightTimer;
    }
}
