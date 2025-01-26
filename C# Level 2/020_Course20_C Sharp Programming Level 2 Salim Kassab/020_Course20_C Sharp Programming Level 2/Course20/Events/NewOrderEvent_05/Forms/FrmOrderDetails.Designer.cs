namespace Course20.Events.NewOrderEvent_05.Forms
{
	partial class FrmOrderDetails
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
			dgvOrderDetails = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			lblTotalAmount = new Label();
			btnByNow = new Button();
			((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
			SuspendLayout();
			// 
			// dgvOrderDetails
			// 
			dgvOrderDetails.AllowUserToAddRows = false;
			dgvOrderDetails.AllowUserToDeleteRows = false;
			dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrderDetails.Location = new Point(12, 37);
			dgvOrderDetails.Name = "dgvOrderDetails";
			dgvOrderDetails.ReadOnly = true;
			dgvOrderDetails.Size = new Size(434, 116);
			dgvOrderDetails.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(158, 9);
			label1.Name = "label1";
			label1.Size = new Size(128, 25);
			label1.TabIndex = 1;
			label1.Text = "Order Details";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(0, 192, 0);
			label2.Location = new Point(12, 170);
			label2.Name = "label2";
			label2.Size = new Size(118, 21);
			label2.TabIndex = 2;
			label2.Text = "Total Amount:";
			// 
			// lblTotalAmount
			// 
			lblTotalAmount.AutoSize = true;
			lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotalAmount.ForeColor = Color.FromArgb(0, 192, 0);
			lblTotalAmount.Location = new Point(136, 170);
			lblTotalAmount.Name = "lblTotalAmount";
			lblTotalAmount.Size = new Size(24, 21);
			lblTotalAmount.TabIndex = 3;
			lblTotalAmount.Text = "??";
			// 
			// btnByNow
			// 
			btnByNow.Location = new Point(371, 168);
			btnByNow.Name = "btnByNow";
			btnByNow.Size = new Size(75, 23);
			btnByNow.TabIndex = 4;
			btnByNow.Text = "Buy Now";
			btnByNow.UseVisualStyleBackColor = true;
			btnByNow.Click += btnByNow_Click;
			// 
			// FrmOrderDetails
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(461, 207);
			Controls.Add(btnByNow);
			Controls.Add(lblTotalAmount);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvOrderDetails);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "FrmOrderDetails";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Order Details";
			((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvOrderDetails;
		private Label label1;
		private Label label2;
		private Label lblTotalAmount;
		private Button btnByNow;
	}
}