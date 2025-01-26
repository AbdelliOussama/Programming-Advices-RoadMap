namespace Course20.Lesson1
{
    partial class Frm2
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
            lblPersonId = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            numericUpDownPersonId = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 0;
            label1.Text = "Person Id Recivied from Form1 is:";
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.ForeColor = Color.Red;
            lblPersonId.Location = new Point(195, 29);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(17, 15);
            lblPersonId.TabIndex = 1;
            lblPersonId.Text = "??";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblPersonId);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 75);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person Id from Form1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDownPersonId);
            groupBox2.Location = new Point(415, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 61);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update recevied Person Id";
            // 
            // numericUpDownPersonId
            // 
            numericUpDownPersonId.Location = new Point(16, 22);
            numericUpDownPersonId.Name = "numericUpDownPersonId";
            numericUpDownPersonId.Size = new Size(120, 23);
            numericUpDownPersonId.TabIndex = 0;
            numericUpDownPersonId.ValueChanged += numericUpDownPersonId_ValueChanged;
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 207);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm2";
            Text = "Frm2";
            Load += Frm2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblPersonId;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDownPersonId;
    }
}