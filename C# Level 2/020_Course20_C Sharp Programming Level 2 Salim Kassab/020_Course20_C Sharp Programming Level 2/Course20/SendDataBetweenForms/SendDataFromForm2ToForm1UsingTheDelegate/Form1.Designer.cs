namespace Course20.Lesson1_001.Send_Data_from_Form1_To_Form2_using_Delegate
{
    partial class Form1
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
            btnOpenForm2 = new Button();
            lblPersonId = new Label();
            SuspendLayout();
            // 
            // btnOpenForm2
            // 
            btnOpenForm2.Location = new Point(25, 28);
            btnOpenForm2.Name = "btnOpenForm2";
            btnOpenForm2.Size = new Size(134, 40);
            btnOpenForm2.TabIndex = 0;
            btnOpenForm2.Text = "Open Form2";
            btnOpenForm2.UseVisualStyleBackColor = true;
            btnOpenForm2.Click += btnOpenForm2_Click;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersonId.ForeColor = Color.Red;
            lblPersonId.Location = new Point(25, 93);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(234, 21);
            lblPersonId.TabIndex = 1;
            lblPersonId.Text = "The Person Id From Form2 is: ?? ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 156);
            Controls.Add(lblPersonId);
            Controls.Add(btnOpenForm2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenForm2;
        private Label lblPersonId;
    }
}