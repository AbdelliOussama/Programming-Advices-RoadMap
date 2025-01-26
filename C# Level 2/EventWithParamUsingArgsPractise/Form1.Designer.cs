namespace EventWithParamUsingArgsPractise
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
            this.ctrlSimpleCalculator1 = new EventWithParamUsingArgsPractise.ctrlSimpleCalculator();
            this.SuspendLayout();
            // 
            // ctrlSimpleCalculator1
            // 
            this.ctrlSimpleCalculator1.BackColor = System.Drawing.Color.Pink;
            this.ctrlSimpleCalculator1.Location = new System.Drawing.Point(2, 3);
            this.ctrlSimpleCalculator1.Name = "ctrlSimpleCalculator1";
            this.ctrlSimpleCalculator1.Size = new System.Drawing.Size(599, 175);
            this.ctrlSimpleCalculator1.TabIndex = 0;
            this.ctrlSimpleCalculator1.OnCalculationComplete += new System.EventHandler<EventWithParamUsingArgsPractise.ctrlSimpleCalculator.CalculationCompleteEventArgs>(this.ctrlSimpleCalculator1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(613, 204);
            this.Controls.Add(this.ctrlSimpleCalculator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSimpleCalculator ctrlSimpleCalculator1;
    }
}

