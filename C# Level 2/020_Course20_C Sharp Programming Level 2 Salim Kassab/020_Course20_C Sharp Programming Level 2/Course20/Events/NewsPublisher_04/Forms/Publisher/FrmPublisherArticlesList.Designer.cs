namespace Course20.Events.NewsPublisher_04.Forms
{
    partial class FrmPublisherArticlesList
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
            lblRecords = new Label();
            label1 = new Label();
            dgvArticles = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            SuspendLayout();
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(96, 241);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(23, 16);
            lblRecords.TabIndex = 11;
            lblRecords.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 241);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 10;
            label1.Text = "Records:";
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(28, 65);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.Size = new Size(387, 150);
            dgvArticles.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(164, 20);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 12;
            label2.Text = "Articles";
            // 
            // FrmListArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 278);
            Controls.Add(label2);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(dgvArticles);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmListArticles";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecords;
        private Label label1;
        private DataGridView dgvArticles;
        private Label label2;
    }
}