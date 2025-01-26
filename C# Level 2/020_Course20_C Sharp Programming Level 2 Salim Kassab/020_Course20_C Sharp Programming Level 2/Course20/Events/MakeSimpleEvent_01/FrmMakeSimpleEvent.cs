using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course20.Events.MakeSimpleEvent
{
    public partial class FrmMakeSimpleEvent : Form
    {
        public FrmMakeSimpleEvent() => InitializeComponent();

        private void ctrlSimpleCalc1_onCalculationCompleted(int obj)
        {
            int result = int.Parse(obj.ToString());

            if (result >= 60)
                MessageBox.Show($"The Result {result} is equal or greater than: 60");
            else
                MessageBox.Show($"The Result {result} is less than: 60");
        }
    }
}