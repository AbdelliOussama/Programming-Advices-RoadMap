namespace Course20.Events.NewOrderEvent_05.Classes.Services
{
	public class ShippingService
	{
		public void subscribe(Order order) => order.onOrderCreated += handeleNewOrder;
		public void unSubscribe(Order order) => order.onOrderCreated -= handeleNewOrder;

		public void handeleNewOrder(object sender, OrderEventArgs orderEventArgs) => MessageBox.Show($"Order details with ID: {orderEventArgs.ID} send to the shipping company");

	}
}
