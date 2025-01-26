using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_DataBack_With_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            frmForm2 frm = new frmForm2();
            frm.DataBack += Send_DataBack;
            frm.ShowDialog();
        }
        private void Send_DataBack(object sender, string Message)
        {
            txtMessage.Text = Message;
        }
    }
}
