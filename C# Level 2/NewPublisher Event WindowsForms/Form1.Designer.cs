namespace NewPublisher_Event_WindowsForms
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
            this.lblMagazineTitle = new System.Windows.Forms.Label();
            this.txtArticleTitle = new System.Windows.Forms.TextBox();
            this.txtArticleContent = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMagazineTitle
            // 
            this.lblMagazineTitle.AutoSize = true;
            this.lblMagazineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineTitle.ForeColor = System.Drawing.Color.Red;
            this.lblMagazineTitle.Location = new System.Drawing.Point(252, 29);
            this.lblMagazineTitle.Name = "lblMagazineTitle";
            this.lblMagazineTitle.Size = new System.Drawing.Size(317, 51);
            this.lblMagazineTitle.TabIndex = 0;
            this.lblMagazineTitle.Text = "Magazine Title";
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Location = new System.Drawing.Point(132, 84);
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.Size = new System.Drawing.Size(530, 30);
            this.txtArticleTitle.TabIndex = 1;
            this.txtArticleTitle.Text = "Write Your Article Title";
            this.txtArticleTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArticleContent
            // 
            this.txtArticleContent.Location = new System.Drawing.Point(29, 129);
            this.txtArticleContent.Multiline = true;
            this.txtArticleContent.Name = "txtArticleContent";
            this.txtArticleContent.Size = new System.Drawing.Size(780, 239);
            this.txtArticleContent.TabIndex = 2;
            this.txtArticleContent.Text = "Here You Write Your Article Content";
            this.txtArticleContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(598, 381);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(211, 46);
            this.btnPublish.TabIndex = 3;
            this.btnPublish.Text = "Publish Your Article";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(846, 439);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtArticleContent);
            this.Controls.Add(this.txtArticleTitle);
            this.Controls.Add(this.lblMagazineTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Article Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMagazineTitle;
        private System.Windows.Forms.TextBox txtArticleTitle;
        private System.Windows.Forms.TextBox txtArticleContent;
        private System.Windows.Forms.Button btnPublish;
    }
}

