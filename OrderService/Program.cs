using System;
using OrderService.Amazon;

namespace OrderService
{
    class Program
    {
        static void Main(string[] args)
        {
            restart:
            PlaceOrder(WelcomeMethod());
            Console.ReadLine();
            goto restart;
        }

        public static int WelcomeMethod()
        {
            Console.WriteLine("Welcome to Your Favorite Store!");
            Console.WriteLine("Input your order number");
            bool success = int.TryParse(Console.ReadLine(), out int orderNumber);
            return orderNumber;
        }

        public static void PlaceOrder(int orderNumber)
        {
            AmazonOrderService os = new AmazonOrderService();
            os.OrderPlaced += OrderNotification;
            os.PlaceOrderWithAmazon(orderNumber);
        }
        
        public static void OrderNotification(string notificationMsg)
        {
            Customer c = CustomerRegistration();
            Console.WriteLine();
            Console.WriteLine("NOTIFICATION ME.SSAGE STARTS");
            Console.WriteLine($"Send {notificationMsg} to {c.EmailAddress} of Customer {c.Fullname}");
            Console.WriteLine("NOTIFICATION MESSAGE ENDS");
        }

        public static Customer CustomerRegistration()
        {
            Customer customer = new Customer()
            {
                EmailAddress = "string",
                Fullname = "String",
                HomeAddress = "String"
            };
            return customer;
        }
    }
}
