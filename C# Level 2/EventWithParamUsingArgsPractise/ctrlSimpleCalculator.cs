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
    public partial class ctrlSimpleCalculator : UserControl
    {
        public ctrlSimpleCalculator()
        {
            InitializeComponent();
        }

        public class CalculationCompleteEventArgs : EventArgs
        {
            public int Number1 { get; }
            public int Number2 { get; }
            public int Number3 { get; }
            public int Result { get; }

            public  CalculationCompleteEventArgs(int number1, int number2, int number3, int result)
            {
                Number1 = number1;
                Number2 = number2;
                Number3 = number3;
                Result = result;
            }
        }


        public event EventHandler <CalculationCompleteEventArgs> OnCalculationComplete;

        public void RaiseCalculationComplete(int Number1,int Number2,int Number3,int Result)
        {
            RaiseCalculationComplete(new CalculationCompleteEventArgs (Number1,Number2,Number3,Result));
        }
        

        protected virtual void RaiseCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Number3 = int.Parse(textBox3.Text);
            int Result = Number1 + Number2 + Number3;

            if(OnCalculationComplete != null)
            {
                RaiseCalculationComplete(Number1, Number2, Number3, Result);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
