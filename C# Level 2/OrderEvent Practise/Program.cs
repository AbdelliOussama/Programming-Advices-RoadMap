using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEvent_Practise
{
    internal class Program
    {

        public class OrderEventArgs : EventArgs
        {
            public int OrderID { get; }
            public string OrderName { get; }
            public int ProductID { get; }
            public string ProductName { get; }
            public string ProductDescription { get; }
            public string ProductCategory { get; }
            public string CLientEmail { get; }
            public double TotalPrice { get; }

            public OrderEventArgs(int OrderID, string OrderName, int ProductID, string ProductName, string ProductDescription, string CLientEmail, string ProductCategory, double TotalPrice)
            {
                this.OrderID = OrderID;
                this.OrderName = OrderName;
                this.ProductID = ProductID;
                this.ProductName = ProductName;
                this.ProductDescription = ProductDescription;
                this.ProductCategory = ProductCategory;
                this.CLientEmail = CLientEmail;
                this.TotalPrice = TotalPrice;

            }

            public class clsOrder
            {
                public event EventHandler<OrderEventArgs> OnOrderCreated;

                public void CreatedOrder(int OrderID, string OrderName, int ProductID, string ProductName, string ProductDescription,
                    string ProductCategory, string ClientEmail, double TotalPrice)
                {
                    Console.WriteLine("New Order created; now will notify eveyone by raising the event.\n");

                    CreatedOrder(this, new OrderEventArgs(OrderID, OrderName, ProductID, ProductName, ProductDescription, ClientEmail, ProductCategory, TotalPrice));
                }


                protected virtual void CreatedOrder(object sender, OrderEventArgs e)
                {
                    OnOrderCreated?.Invoke(sender, e);
                }

            }

            public class clsEmailServise
            {
                public void Subscribe(clsOrder order)
                {
                    order.OnOrderCreated += HandelOrderEmail;
                }

                public void Unsubscribe(clsOrder order)
                {
                    order.OnOrderCreated -= HandelOrderEmail;
                }
                public void HandelOrderEmail(object sender, OrderEventArgs e)
                {
                    Console.WriteLine($"----------Email Service--------");
                    Console.WriteLine($"Email Service Object Received a new order event");
                    Console.WriteLine($"OrderID = {e.OrderID}");
                    Console.WriteLine($"OrderName = {e.OrderName}");
                    Console.WriteLine($"ProductID = {e.ProductID}");
                    Console.WriteLine($"ProductName = {e.ProductName}");
                    Console.WriteLine($"ProductDescription = {e.ProductDescription}");
                    Console.WriteLine($"ProductCategory = {e.ProductCategory}");
                    Console.WriteLine($"ClientEmail = {e.CLientEmail}");
                    Console.WriteLine($"TotalPrice = {e.TotalPrice}");
                    Console.WriteLine($"--------------------------------");
                    /*
                     here you write the code to send the email to the client 
                     */
                    Console.WriteLine();
                }
            }

            public class clsSMSServise
            {
                public void Subscribe(clsOrder order)
                {
                    order.OnOrderCreated += HandelOrderEmail;
                }

                public void Unsubscribe(clsOrder order)
                {
                    order.OnOrderCreated -= HandelOrderEmail;
                }
                public void HandelOrderEmail(object sender, OrderEventArgs e)
                {
                    Console.WriteLine($"----------SMS Service--------");
                    Console.WriteLine($"SMS Service Object Received a new order event");
                    Console.WriteLine($"OrderID = {e.OrderID}");
                    Console.WriteLine($"OrderName = {e.OrderName}");
                    Console.WriteLine($"ProductID = {e.ProductID}");
                    Console.WriteLine($"ProductName = {e.ProductName}");
                    Console.WriteLine($"ProductDescription = {e.ProductDescription}");
                    Console.WriteLine($"ProductCategory = {e.ProductCategory}");
                    Console.WriteLine($"ClientEmail = {e.CLientEmail}");
                    Console.WriteLine($"TotalPrice = {e.TotalPrice}");
                    Console.WriteLine($"--------------------------------");
                    /*
                     here you write the code to send the SMS to the client 
                     */
                    Console.WriteLine();
                }
            }


            public class clsShippingServise
            {
                public void Subscribe(clsOrder order)
                {
                    order.OnOrderCreated += HandelOrderEmail;
                }

                public void Unsubscribe(clsOrder order)
                {
                    order.OnOrderCreated -= HandelOrderEmail;
                }
                public void HandelOrderEmail(object sender, OrderEventArgs e)
                {
                    Console.WriteLine($"----------Shipping Service--------");
                    Console.WriteLine($"Email Service Object Received a new order event");
                    Console.WriteLine($"OrderID = {e.OrderID}");
                    Console.WriteLine($"OrderName = {e.OrderName}");
                    Console.WriteLine($"ProductID = {e.ProductID}");
                    Console.WriteLine($"ProductName = {e.ProductName}");
                    Console.WriteLine($"ProductDescription = {e.ProductDescription}");
                    Console.WriteLine($"ProductCategory = {e.ProductCategory}");
                    Console.WriteLine($"ClientEmail = {e.CLientEmail}");
                    Console.WriteLine($"TotalPrice = {e.TotalPrice}");
                    Console.WriteLine($"--------------------------------");
                    /*
                     here you write the code to Handel The Shipping to the client 
                     */
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {

                clsOrder order = new clsOrder();
                clsEmailServise emailServise = new clsEmailServise();
                clsShippingServise shippingServise = new clsShippingServise();
                clsSMSServise SMSServise = new clsSMSServise();


                emailServise.Subscribe(order);
                shippingServise.Subscribe(order);
                SMSServise.Subscribe(order);

                order.CreatedOrder(1, "Express", 3, "BoxingGloves", "The Product is A boxing Gloves For Sparring", "Sport", "oussama.abdelli@gmail.com", 15000);


                Console.ReadKey();
            }
        }
    }
}
