namespace Course20.Lesson1
{
    public partial class Frm1 : Form
    {
        public Frm1() => InitializeComponent();



        //////////// Send PersonId Without Delegate ///////////
        private void sendPersonIdWithoutDelegate()
        {
            Frm2 frm2 = new(int.Parse(numericUpDownPersonId.Text));
            frm2.ShowDialog();

            int receviedPersonId = frm2.UpdatedPersonId;
            lblUpdatedPersonId.Text = receviedPersonId.ToString();
            numericUpDownPersonId.Value = receviedPersonId;
        }

        private void btnSend_Click(object sender, EventArgs e) => sendPersonIdWithoutDelegate();

        ////////////////////////////////////////////////////////
    }
}