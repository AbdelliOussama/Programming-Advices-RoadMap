namespace Course20.Events.SimpleEventWithParametersUsingArguments_02
{
    partial class FrmSimpleCalc2
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
            ctrlSimpleCalc21 = new CtrlSimpleCalc2();
            SuspendLayout();
            // 
            // ctrlSimpleCalc21
            // 
            ctrlSimpleCalc21.Location = new Point(12, 12);
            ctrlSimpleCalc21.Name = "ctrlSimpleCalc21";
            ctrlSimpleCalc21.Size = new Size(423, 35);
            ctrlSimpleCalc21.TabIndex = 0;

            ctrlSimpleCalc21.OnCalculationComplete += ctrlSimpleCalc21_OnCalculationComplete;
            
            // 
            // FrmSimpleCalc2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 93);
            Controls.Add(ctrlSimpleCalc21);
            Name = "FrmSimpleCalc2";
            Text = "FrmSimpleCalc2";
            ResumeLayout(false);
        }

        #endregion

        private CtrlSimpleCalc2 ctrlSimpleCalc21;
    }
}