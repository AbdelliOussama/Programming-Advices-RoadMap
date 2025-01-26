namespace Course20.Events.NewsPublisher_04
{
    partial class FrmArticlesPublisherHome
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
            btnPublish = new Button();
            label2 = new Label();
            btnShowArticles = new Button();
            SuspendLayout();
            // 
            // btnPublish
            // 
            btnPublish.Font = new Font("Simplified Arabic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPublish.Location = new Point(33, 59);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(168, 35);
            btnPublish.TabIndex = 6;
            btnPublish.Text = "Publish a New Article";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 9;
            label2.Text = "Articles Publisher";
            // 
            // btnShowArticles
            // 
            btnShowArticles.Font = new Font("Simplified Arabic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowArticles.Location = new Point(33, 110);
            btnShowArticles.Name = "btnShowArticles";
            btnShowArticles.Size = new Size(168, 35);
            btnShowArticles.TabIndex = 10;
            btnShowArticles.Text = "Show Articles";
            btnShowArticles.UseVisualStyleBackColor = true;
            btnShowArticles.Click += btnShowArticles_Click;
            // 
            // FrmArticlesHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 175);
            Controls.Add(btnShowArticles);
            Controls.Add(label2);
            Controls.Add(btnPublish);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmArticlesHome";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPublish;
        private Label label2;
        private Button btnShowArticles;
    }
}