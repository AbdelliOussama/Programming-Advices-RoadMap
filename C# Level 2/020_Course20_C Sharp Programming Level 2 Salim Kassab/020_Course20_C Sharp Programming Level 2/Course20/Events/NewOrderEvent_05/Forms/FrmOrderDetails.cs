using Course20.Events.NewOrderEvent_05.Classes;

namespace Course20.Events.NewOrderEvent_05.Forms
{
	public partial class FrmOrderDetails : Form
	{
		private decimal _totalAmount = 0;
		public FrmOrderDetails(List<Product> products, decimal totalAmount)
		{
			InitializeComponent();
			dgvOrderDetails.DataSource = products;
			_totalAmount = totalAmount;
			lblTotalAmount.Text = totalAmount.ToString() + " $";
		}

		private void btnByNow_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to order now?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;


			Form1.orderAlarm.create(1, _totalAmount, "saleemkassab5@gmail.com");
		}
	}
}