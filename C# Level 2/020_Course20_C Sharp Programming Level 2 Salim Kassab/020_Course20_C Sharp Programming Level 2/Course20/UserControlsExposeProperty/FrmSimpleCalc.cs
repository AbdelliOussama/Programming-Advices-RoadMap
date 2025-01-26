namespace Course20.UserControlsExposeProperty
{
    public partial class FrmSimpleCalc : Form
    {
        public FrmSimpleCalc() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e) => MessageBox.Show(ctrlSimpleCalc1.CalcResult.ToString());

    }
}
