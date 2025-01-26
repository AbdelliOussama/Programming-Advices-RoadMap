using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWithParamUsingArgsPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlSimpleCalculator1_OnCalculationComplete(object sender, ctrlSimpleCalculator.CalculationCompleteEventArgs e)
        {
            MessageBox.Show(e.Number1 + " + " + e.Number2 + " + " + e.Number3 + " = " + e.Result);
        }
    }
}
