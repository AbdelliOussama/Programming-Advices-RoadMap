namespace Course20.Lesson1_001.Send_Data_from_Form1_To_Form2_using_Delegate
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new();
            frm2.DataBack += form2DataBack;
            frm2.ShowDialog();
        }

        private void form2DataBack(object sender, int personId)
        {
            lblPersonId.Text = personId.ToString();
        }
    }
}
