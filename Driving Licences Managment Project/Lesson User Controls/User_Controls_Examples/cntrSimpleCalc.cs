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
    public partial class cntrSimpleCalc : UserControl
    {
        public cntrSimpleCalc()
        {
            InitializeComponent();
        }
        public float Result 
        {
           get { return (float)Convert.ToDouble(lblResult.Text); }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text=(int.Parse(txtNumber1.Text)+int.Parse(txtNumber2.Text)).ToString();
        }
    }
}
