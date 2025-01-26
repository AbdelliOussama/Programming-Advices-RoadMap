namespace Course20.Events.NewOrderEvent_05.Classes.Services
{
	public class EmailService
	{
		public void subscribe(Order order) => order.onOrderCreated += handeleNewOrder;
		public void unSubscribe(Order order) => order.onOrderCreated -= handeleNewOrder;

		public void handeleNewOrder(object sender, OrderEventArgs orderEventArgs) => MessageBox.Show($"Order Details send to client's email: {orderEventArgs.ClientEmail}");
	}
}