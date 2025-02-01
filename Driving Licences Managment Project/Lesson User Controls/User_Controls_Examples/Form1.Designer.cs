namespace User_Controls_Examples
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
            this.cntrSimpleCalc1 = new User_Controls_Examples.cntrSimpleCalc();
            this.cntrSimpleCalc2 = new User_Controls_Examples.cntrSimpleCalc();
            this.cntrSimpleCalc3 = new User_Controls_Examples.cntrSimpleCalc();
            this.cntrSimpleCalc4 = new User_Controls_Examples.cntrSimpleCalc();
            this.btnHidecntr1 = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrSimpleCalc1
            // 
            this.cntrSimpleCalc1.Location = new System.Drawing.Point(23, 12);
            this.cntrSimpleCalc1.Name = "cntrSimpleCalc1";
            this.cntrSimpleCalc1.Size = new System.Drawing.Size(256, 188);
            this.cntrSimpleCalc1.TabIndex = 0;
            // 
            // cntrSimpleCalc2
            // 
            this.cntrSimpleCalc2.Location = new System.Drawing.Point(299, 13);
            this.cntrSimpleCalc2.Name = "cntrSimpleCalc2";
            this.cntrSimpleCalc2.Size = new System.Drawing.Size(253, 187);
            this.cntrSimpleCalc2.TabIndex = 1;
            // 
            // cntrSimpleCalc3
            // 
            this.cntrSimpleCalc3.Location = new System.Drawing.Point(23, 222);
            this.cntrSimpleCalc3.Name = "cntrSimpleCalc3";
            this.cntrSimpleCalc3.Size = new System.Drawing.Size(253, 187);
            this.cntrSimpleCalc3.TabIndex = 2;
            // 
            // cntrSimpleCalc4
            // 
            this.cntrSimpleCalc4.Location = new System.Drawing.Point(299, 222);
            this.cntrSimpleCalc4.Name = "cntrSimpleCalc4";
            this.cntrSimpleCalc4.Size = new System.Drawing.Size(253, 187);
            this.cntrSimpleCalc4.TabIndex = 3;
            // 
            // btnHidecntr1
            // 
            this.btnHidecntr1.Location = new System.Drawing.Point(611, 177);
            this.btnHidecntr1.Name = "btnHidecntr1";
            this.btnHidecntr1.Size = new System.Drawing.Size(127, 23);
            this.btnHidecntr1.TabIndex = 4;
            this.btnHidecntr1.Text = "Hide Calculator1";
            this.btnHidecntr1.UseVisualStyleBackColor = true;
            this.btnHidecntr1.Click += new System.EventHandler(this.btnHidecntr1_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(624, 126);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(75, 23);
            this.btnShowResult.TabIndex = 5;
            this.btnShowResult.Text = "Result";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnHidecntr1);
            this.Controls.Add(this.cntrSimpleCalc4);
            this.Controls.Add(this.cntrSimpleCalc3);
            this.Controls.Add(this.cntrSimpleCalc2);
            this.Controls.Add(this.cntrSimpleCalc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private cntrSimpleCalc cntrSimpleCalc1;
        private cntrSimpleCalc cntrSimpleCalc2;
        private cntrSimpleCalc cntrSimpleCalc3;
        private cntrSimpleCalc cntrSimpleCalc4;
        private System.Windows.Forms.Button btnHidecntr1;
        private System.Windows.Forms.Button btnShowResult;
    }
}

