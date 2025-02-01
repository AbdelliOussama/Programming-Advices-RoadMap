using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExmple
{
    public partial class Form2 : Form
    {

        public delegate void DataBackEventHandeler(object sender, int ID_Number, string First_Name, string Last_Name, string Country);
        public event DataBackEventHandeler DataBack;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendDataBack_ToForm1_Click(object sender, EventArgs e)
        {
            int ID_Number = int.Parse(txtID_Number.Text);
            string First_Name = txtFirstName.Text;
            string Last_Name = txtLastName.Text;
            string Country = txtCountry.Text;

            DataBack?.Invoke(this, ID_Number, First_Name, Last_Name, Country);
            this.Close();
        }
    }
}
