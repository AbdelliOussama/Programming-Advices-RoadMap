namespace DelegateExmple
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
            this.txtID_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendDataBack_ToForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID_Number
            // 
            this.txtID_Number.Location = new System.Drawing.Point(151, 70);
            this.txtID_Number.Name = "txtID_Number";
            this.txtID_Number.Size = new System.Drawing.Size(100, 20);
            this.txtID_Number.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID_Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(16, 160);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last_Name";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(151, 160);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Country";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "First_Name";
            // 
            // btnSendDataBack_ToForm1
            // 
            this.btnSendDataBack_ToForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendDataBack_ToForm1.Location = new System.Drawing.Point(216, 212);
            this.btnSendDataBack_ToForm1.Name = "btnSendDataBack_ToForm1";
            this.btnSendDataBack_ToForm1.Size = new System.Drawing.Size(198, 33);
            this.btnSendDataBack_ToForm1.TabIndex = 9;
            this.btnSendDataBack_ToForm1.Text = "Send Data To Form1";
            this.btnSendDataBack_ToForm1.UseVisualStyleBackColor = true;
            this.btnSendDataBack_ToForm1.Click += new System.EventHandler(this.btnSendDataBack_ToForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.txtID_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendDataBack_ToForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID_Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendDataBack_ToForm1;
    }
}