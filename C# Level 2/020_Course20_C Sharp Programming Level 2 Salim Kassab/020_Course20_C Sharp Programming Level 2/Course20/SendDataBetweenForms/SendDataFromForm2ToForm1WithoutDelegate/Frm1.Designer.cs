namespace Course20.Lesson1
{
    partial class Frm1
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
            label1 = new Label();
            btnSend = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblUpdatedPersonId = new Label();
            numericUpDownPersonId = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Person Id:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(227, 35);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(123, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send Data To Form2";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownPersonId);
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send Person Id Form2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUpdatedPersonId);
            groupBox2.Location = new Point(439, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 90);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person Id after add values from Form2 without delegate";
            // 
            // lblUpdatedPersonId
            // 
            lblUpdatedPersonId.AutoSize = true;
            lblUpdatedPersonId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpdatedPersonId.ForeColor = Color.Red;
            lblUpdatedPersonId.Location = new Point(28, 28);
            lblUpdatedPersonId.Name = "lblUpdatedPersonId";
            lblUpdatedPersonId.Size = new Size(24, 21);
            lblUpdatedPersonId.TabIndex = 0;
            lblUpdatedPersonId.Text = "??";
            // 
            // numericUpDownPersonId
            // 
            numericUpDownPersonId.Location = new Point(77, 35);
            numericUpDownPersonId.Name = "numericUpDownPersonId";
            numericUpDownPersonId.Size = new Size(120, 23);
            numericUpDownPersonId.TabIndex = 3;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 264);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm1";
            Text = "Frm1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSend;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblUpdatedPersonId;
        private NumericUpDown numericUpDownPersonId;
    }
}