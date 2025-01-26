using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Table_My_Version
{
    public partial class frmInputData : Form
    {
        public delegate void SendDataBackEventHabdler(object sender, string PlayerName, float HourRate);

        public SendDataBackEventHabdler DataBack;

      
        public frmInputData()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string PlayerName = txtPlayerName.Text;
            float HourRate = Convert.ToSingle(txtHourRate.Text);
            DataBack?.Invoke(this, PlayerName, HourRate);
            this.Close();
        }

        private void txtHourRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
