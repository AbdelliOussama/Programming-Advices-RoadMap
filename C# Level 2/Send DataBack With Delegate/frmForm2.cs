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
      
    public partial class frmForm2 : Form
    {
        public delegate void DataBackEventHandler(object sender, string Message);

        public DataBackEventHandler DataBack;
        public frmForm2()
        {
            InitializeComponent();
        }


        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            string Message = txtMessage.Text;
            DataBack?.Invoke(this, Message);
            this.Close();
        }
    }
}
