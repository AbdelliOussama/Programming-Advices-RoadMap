namespace Pool_Table_My_Version
{
    partial class frmPoolArea
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
            this.ctrlPoolTable2 = new Pool_Table_My_Version.ctrlPoolTable();
            this.ctrlPoolTable1 = new Pool_Table_My_Version.ctrlPoolTable();
            this.SuspendLayout();
            // 
            // ctrlPoolTable2
            // 
            this.ctrlPoolTable2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ctrlPoolTable2.HourRate = 50F;
            this.ctrlPoolTable2.Location = new System.Drawing.Point(705, 147);
            this.ctrlPoolTable2.Name = "ctrlPoolTable2";
            this.ctrlPoolTable2.PlayerName = "Salim Khouya";
            this.ctrlPoolTable2.Size = new System.Drawing.Size(543, 377);
            this.ctrlPoolTable2.TabIndex = 1;
            this.ctrlPoolTable2.TableName = "Private Table";
            this.ctrlPoolTable2.OnPoolTabelComplete += new System.EventHandler<Pool_Table_My_Version.ctrlPoolTable.PoolTabelEventArgs>(this.ctrlPoolTable_OnPoolTabelComplete);
            // 
            // ctrlPoolTable1
            // 
            this.ctrlPoolTable1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ctrlPoolTable1.HourRate = 10F;
            this.ctrlPoolTable1.Location = new System.Drawing.Point(28, 147);
            this.ctrlPoolTable1.Name = "ctrlPoolTable1";
            this.ctrlPoolTable1.PlayerName = "Oussama";
            this.ctrlPoolTable1.Size = new System.Drawing.Size(543, 377);
            this.ctrlPoolTable1.TabIndex = 0;
            this.ctrlPoolTable1.TableName = "Table 1";
            this.ctrlPoolTable1.OnPoolTabelComplete += new System.EventHandler<Pool_Table_My_Version.ctrlPoolTable.PoolTabelEventArgs>(this.ctrlPoolTable_OnPoolTabelComplete);
            // 
            // frmPoolArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Pool_Table_My_Version.Properties.Resources.téléchargement;
            this.ClientSize = new System.Drawing.Size(1324, 645);
            this.Controls.Add(this.ctrlPoolTable2);
            this.Controls.Add(this.ctrlPoolTable1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPoolArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoolArea";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPoolTable ctrlPoolTable1;
        private ctrlPoolTable ctrlPoolTable2;
    }
}