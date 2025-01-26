namespace Course20.Events.NewOrderEvent_05.Classes
{
	public class OrderEventArgs : EventArgs
	{
		public int ID { get; set; }
		public decimal TotalPrice { get; set; }
		public string ClientEmail { get; set; }

		public OrderEventArgs(int id, decimal totalPrice, string clientEmail)
		{
			ID = id;
			TotalPrice = totalPrice;
			ClientEmail = clientEmail;
		}
	}
}