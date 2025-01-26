namespace Course20.Lesson1
{
    public partial class Frm2 : Form
    {

        public Frm2(int personId)
        {
            InitializeComponent();
            _personId = personId;
        }

        //////////// Send PersonId Without Delegate ///////////
        private int _personId;
        public int UpdatedPersonId;

        private void Frm2_Load(object sender, EventArgs e)
        {
            lblPersonId.Text = _personId.ToString();
            numericUpDownPersonId.Value = _personId;
        }

        private void numericUpDownPersonId_ValueChanged(object sender, EventArgs e)
        {
            UpdatedPersonId = int.Parse(numericUpDownPersonId.Value.ToString());
            lblPersonId.Text = UpdatedPersonId.ToString();
        }

        ///////////////////////////////////////////////////////////
    }
}