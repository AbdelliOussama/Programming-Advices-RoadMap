namespace Course20.Lesson1_001.Send_Data_from_Form1_To_Form2_using_Delegate
{
    public partial class Form2 : Form
    {
        // Declare the delegation
        public delegate void DataBackEventHandler(object sender, int personId);

        // Declare an Event to use the above delegate
        public event DataBackEventHandler DataBack;

        public Form2() => InitializeComponent();

        private void btnSendPersonIdBackToForm1_Click(object sender, EventArgs e)
        {
            int personId = int.Parse(numericUpDownPersonId.Value.ToString());

            DataBack.Invoke(this, personId);
            this.Close();
        }
    }
}