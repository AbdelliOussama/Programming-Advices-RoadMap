namespace Course20.Events.SimpleEventWithParametersUsingArguments_02
{
    public partial class CtrlSimpleCalc2 : UserControl
    {
        public CtrlSimpleCalc2() => InitializeComponent();

        public class CalculationCompleteEventArgs : EventArgs
        {
            public int Result { get; }
            public int Value1 { get; }
            public int Value2 { get; }

            public CalculationCompleteEventArgs(int result, int value1, int value2)
            {
                Result = result;
                Value1 = value1;
                Value2 = value2;
            }
        }

        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        public void RaiseOnCalculationComplete(int result, int value1, int value2)
        {
            RaiseOnCalculationComplete(new CalculationCompleteEventArgs(result, value1, value2));
        }

        protected virtual void RaiseOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(numericUpDown1.Value.ToString()),
                valu2 = int.Parse(numericUpDown2.Value.ToString()),
                result = value1 + valu2;

            lblResult.Text = result.ToString();

            if (OnCalculationComplete is not null)
                RaiseOnCalculationComplete(result, value1, valu2);
        }
    }
}