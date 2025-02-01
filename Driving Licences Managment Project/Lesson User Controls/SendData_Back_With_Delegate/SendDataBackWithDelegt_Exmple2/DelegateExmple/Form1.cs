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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.DataBack += Form2DataBack;
            frm2.ShowDialog();

        }

        public void Form2DataBack(Object sender,int ID_Number,string First_Name,string Last_Name,string Country)
        {
            txtID_Number.Text = ID_Number.ToString();
            txtFirstName.Text = First_Name;
            txtLastName.Text = Last_Name;
            txtCountry.Text = Country;

        }
    }
}
