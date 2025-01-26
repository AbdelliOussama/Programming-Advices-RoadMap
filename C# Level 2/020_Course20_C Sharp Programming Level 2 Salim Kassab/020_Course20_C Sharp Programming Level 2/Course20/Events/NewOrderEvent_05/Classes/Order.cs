namespace Course20.Events.NewOrderEvent_05.Classes
{
	public class Order
	{
		public event EventHandler<OrderEventArgs> onOrderCreated;

		public void create(int orderId, decimal totalPrice, string clientEmail)
		{
			if (onOrderCreated is not null)
				onOrderCreated(this, new OrderEventArgs(orderId, totalPrice, clientEmail));
		}
	}
}
