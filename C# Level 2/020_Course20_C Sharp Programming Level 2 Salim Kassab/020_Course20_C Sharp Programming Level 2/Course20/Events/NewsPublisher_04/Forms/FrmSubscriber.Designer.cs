namespace Course20.Events.NewsPublisher_04.Forms.Subscribers
{
    partial class FrmSubscriber
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
            lblSubscriberNumber = new Label();
            label2 = new Label();
            lblRecords = new Label();
            label1 = new Label();
            dgvSubscribedArticles = new DataGridView();
            btnSubscribe = new Button();
            btnUnsubscribe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribedArticles).BeginInit();
            SuspendLayout();
            // 
            // lblSubscriberNumber
            // 
            lblSubscriberNumber.AutoSize = true;
            lblSubscriberNumber.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubscriberNumber.ForeColor = Color.FromArgb(0, 192, 0);
            lblSubscriberNumber.Location = new Point(294, 8);
            lblSubscriberNumber.Name = "lblSubscriberNumber";
            lblSubscriberNumber.Size = new Size(36, 31);
            lblSubscriberNumber.TabIndex = 11;
            lblSubscriberNumber.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(59, 8);
            label2.Name = "label2";
            label2.Size = new Size(239, 31);
            label2.TabIndex = 10;
            label2.Text = "Subscriber Number:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(80, 227);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(23, 16);
            lblRecords.TabIndex = 14;
            lblRecords.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 227);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 13;
            label1.Text = "Records:";
            // 
            // dgvSubscribedArticles
            // 
            dgvSubscribedArticles.AllowUserToAddRows = false;
            dgvSubscribedArticles.AllowUserToDeleteRows = false;
            dgvSubscribedArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscribedArticles.Location = new Point(12, 102);
            dgvSubscribedArticles.Name = "dgvSubscribedArticles";
            dgvSubscribedArticles.ReadOnly = true;
            dgvSubscribedArticles.Size = new Size(387, 113);
            dgvSubscribedArticles.TabIndex = 12;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(12, 62);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(75, 23);
            btnSubscribe.TabIndex = 15;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(102, 62);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(75, 23);
            btnUnsubscribe.TabIndex = 15;
            btnUnsubscribe.Text = "Unsubscribe";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubscribe_Click;
            // 
            // FrmSubscriber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 256);
            Controls.Add(btnUnsubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(dgvSubscribedArticles);
            Controls.Add(lblSubscriberNumber);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmSubscriber";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvSubscribedArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSubscriberNumber;
        private Label label2;
        private Label lblRecords;
        private Label label1;
        private DataGridView dgvSubscribedArticles;
        private Button btnSubscribe;
        private Button btnUnsubscribe;
    }
}