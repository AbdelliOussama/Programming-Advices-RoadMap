namespace User_Controls_Examples
{
    partial class cntrSimpleCalc
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(36, 49);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(36, 110);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(162, 72);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(67, 13);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(50, 13);
            this.lblNumber1.TabIndex = 3;
            this.lblNumber1.Text = "Number1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(67, 82);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(50, 13);
            this.lblNumber2.TabIndex = 4;
            this.lblNumber2.Text = "Number2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(67, 157);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "??????";
            // 
            // cntrSimpleCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "cntrSimpleCalc";
            this.Size = new System.Drawing.Size(253, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblResult;
    }
}
