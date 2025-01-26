namespace Course20.Lesson1_001.Send_Data_from_Form1_To_Form2_using_Delegate
{
    partial class Form2
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
            numericUpDownPersonId = new NumericUpDown();
            label1 = new Label();
            btnSendPersonIdBackToForm1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonId).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownPersonId
            // 
            numericUpDownPersonId.Location = new Point(92, 22);
            numericUpDownPersonId.Name = "numericUpDownPersonId";
            numericUpDownPersonId.Size = new Size(120, 23);
            numericUpDownPersonId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Person Id:";
            // 
            // btnSendPersonIdBackToForm1
            // 
            btnSendPersonIdBackToForm1.Location = new Point(14, 72);
            btnSendPersonIdBackToForm1.Name = "btnSendPersonIdBackToForm1";
            btnSendPersonIdBackToForm1.Size = new Size(198, 23);
            btnSendPersonIdBackToForm1.TabIndex = 2;
            btnSendPersonIdBackToForm1.Text = "Send Person Id Back To Form1";
            btnSendPersonIdBackToForm1.UseVisualStyleBackColor = true;
            btnSendPersonIdBackToForm1.Click += btnSendPersonIdBackToForm1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 123);
            Controls.Add(btnSendPersonIdBackToForm1);
            Controls.Add(label1);
            Controls.Add(numericUpDownPersonId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownPersonId;
        private Label label1;
        private Button btnSendPersonIdBackToForm1;
    }
}