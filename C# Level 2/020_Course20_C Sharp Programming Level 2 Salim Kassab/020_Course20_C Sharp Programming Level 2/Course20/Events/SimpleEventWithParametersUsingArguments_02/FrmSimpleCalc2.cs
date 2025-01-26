using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course20.Events.SimpleEventWithParametersUsingArguments_02
{
    public partial class FrmSimpleCalc2 : Form
    {
        public FrmSimpleCalc2() => InitializeComponent();


        private void ctrlSimpleCalc21_OnCalculationComplete(object sender, CtrlSimpleCalc2.CalculationCompleteEventArgs e)
        {
            MessageBox.Show($"Result = {e.Result}, value1= {e.Value1}, value2= {e.Value2}");
        }
    }
}
