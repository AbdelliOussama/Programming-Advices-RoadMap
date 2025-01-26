namespace Course20.Events.NewsPublisher_04
{
    partial class FrmCreateArticle
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
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContent = new TextBox();
            btnPublish = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(35, 106);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(322, 23);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 73);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(64, 9);
            label2.Name = "label2";
            label2.Size = new Size(251, 31);
            label2.TabIndex = 2;
            label2.Text = "Publish a New Article";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 162);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 3;
            label3.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(35, 195);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(322, 111);
            txtContent.TabIndex = 4;
            // 
            // btnPublish
            // 
            btnPublish.Font = new Font("Simplified Arabic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPublish.Location = new Point(282, 337);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(75, 35);
            btnPublish.TabIndex = 5;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // FrmNewsPublisher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 383);
            Controls.Add(btnPublish);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmNewsPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContent;
        private Button btnPublish;
    }
}