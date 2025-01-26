using Course20.Events.NewOrderEvent_05.Classes;

namespace Course20.Events.NewOrderEvent_05.Forms
{
	public partial class FrmShoppingMarketHome : Form
	{
		private List<Product> _products = [];
		private int _itemsCount = 0;

		public FrmShoppingMarketHome()
		{
			InitializeComponent();
			btnOrderDetails.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product product = new()
			{
				ID = 1,
				Name = "Hawaii Laptop",
				Price = 1500,
				Quantity = numericUpDown1.Value
			};
			_products.Add(product);
			_itemsCount++;
			lblItemsCount.Text = _itemsCount.ToString();
			numericUpDown1.Enabled = false;
			button1.Enabled = false;
			btnOrderDetails.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product product = new()
			{
				ID = 2,
				Name = "HP Laptop",
				Price = 1320,
				Quantity = numericUpDown2.Value
			};
			_products.Add(product);
			_itemsCount++;
			lblItemsCount.Text = _itemsCount.ToString();
			numericUpDown2.Enabled = false;
			button2.Enabled = false;
			btnOrderDetails.Enabled = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product product = new()
			{
				ID = 3,
				Name = "Apple Laptop",
				Price = 1730,
				Quantity = numericUpDown3.Value
			};
			_products.Add(product);
			_itemsCount++;
			lblItemsCount.Text = _itemsCount.ToString();
			numericUpDown3.Enabled = false;
			button3.Enabled = false;
			btnOrderDetails.Enabled = true;
		}

		private void btnOrderDetails_Click(object sender, EventArgs e)
		{
			decimal totalAmount = 0;

			foreach (Product product in _products)
				totalAmount += product.Price * product.Quantity;

			FrmOrderDetails frmOrderDetails = new(_products, totalAmount);
			frmOrderDetails.ShowDialog();
		}
	}
}
