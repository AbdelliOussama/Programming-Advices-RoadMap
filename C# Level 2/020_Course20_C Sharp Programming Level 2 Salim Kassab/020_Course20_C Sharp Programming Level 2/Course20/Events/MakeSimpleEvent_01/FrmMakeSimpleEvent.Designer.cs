namespace Course20.Events.MakeSimpleEvent
{
    partial class FrmMakeSimpleEvent
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
            ctrlSimpleCalc1 = new UserControlsExposeProperty.CtrlSimpleCalc();
            SuspendLayout();
            // 
            // ctrlSimpleCalc1
            // 
            ctrlSimpleCalc1.Location = new Point(12, 12);
            ctrlSimpleCalc1.Name = "ctrlSimpleCalc1";
            ctrlSimpleCalc1.Size = new Size(448, 40);
            ctrlSimpleCalc1.TabIndex = 0;
            ctrlSimpleCalc1.onCalculationCompleted += ctrlSimpleCalc1_onCalculationCompleted;
            // 
            // FrmMakeSimpleEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 56);
            Controls.Add(ctrlSimpleCalc1);
            Name = "FrmMakeSimpleEvent";
            Text = "Frm Make Simple Event";
            ResumeLayout(false);
        }

        #endregion

        private UserControlsExposeProperty.CtrlSimpleCalc ctrlSimpleCalc1;
    }
}