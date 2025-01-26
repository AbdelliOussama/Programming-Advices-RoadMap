namespace Course20.UserControlsExposeProperty
{
    partial class FrmSimpleCalc
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
            ctrlSimpleCalc1 = new CtrlSimpleCalc();
            button1 = new Button();
            SuspendLayout();
            // 
            // ctrlSimpleCalc1
            // 
            ctrlSimpleCalc1.Location = new Point(12, 12);
            ctrlSimpleCalc1.Name = "ctrlSimpleCalc1";
            ctrlSimpleCalc1.Size = new Size(483, 41);
            ctrlSimpleCalc1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 1;
            button1.Text = "ExposeResult";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmSimpleCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ctrlSimpleCalc1);
            Name = "FrmSimpleCalc";
            Text = "FrmSimpleCalc";
            ResumeLayout(false);
        }

        #endregion

        private CtrlSimpleCalc ctrlSimpleCalc1;
        private Button button1;
    }
}