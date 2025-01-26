using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPractise1
{
    public partial class ctrlSimpleCalculator : UserControl
    {
        public event Action<int> OnCalculationComplete;
        protected virtual void CalculationComplete(int Result)
        {
            Action<int> Handler = OnCalculationComplete;
            if(Handler != null)
            {
                Handler(Result);
            }
        }
        public ctrlSimpleCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            label1.Text= Result.ToString();
            if(OnCalculationComplete != null)
                CalculationComplete(Result);
        }
    }
}
