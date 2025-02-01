using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Controls_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHidecntr1_Click(object sender, EventArgs e)
        {
            cntrSimpleCalc1.Hide();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cntrSimpleCalc1.Result.ToString(), "Result", MessageBoxButtons.OK);
        }
    }
}
