namespace Course20.UserControlsExposeProperty
{
    public partial class CtrlSimpleCalc : UserControl
    {
        public int CalcResult { get; private set; }

        // Create Event
        public event Action<int> onCalculationCompleted;

        protected virtual void CalculationCompleted(int calcResult)
        {
            Action<int> handler = onCalculationCompleted;
            if (handler is not null)
                handler(calcResult);
        }
        //////////////

        public CtrlSimpleCalc() => InitializeComponent();

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int result = int.Parse(numericUpDown1.Value.ToString()) + int.Parse(numericUpDown2.Value.ToString());
            lblResult.Text = result.ToString();
            CalcResult = result;

            if (onCalculationCompleted is not null)
                CalculationCompleted(result);
        }
    }
}