using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Amazon
{
    public class AmazonOrderService
    {
        public delegate void OrderPlacedHandler(string notifcationMsg);
        public event OrderPlacedHandler OrderPlaced;

        public void OrderPlacedMethod(int orderNumber)
        {
            string orderDetails = orderNumber.ToString();
            string messageNotification = orderDetails + " has been placed at " + DateTime.Now.ToString();
            OrderPlaced?.Invoke(messageNotification);
        }
        List<int> orderList = new List<int>() {
            4, 5, 6
        };
        public void PlaceOrderWithAmazon(int orderNumber)
        {
            if (orderList.Contains(orderNumber))
            {
                OrderPlacedMethod(orderNumber);
            }
            else
            {
                OrderNotPlacedMethod(orderNumber);
            }
        }

        private void OrderNotPlacedMethod(int orderNumber)
        {
            string notifcationMsg = orderNumber + " is not in stock!";
            OrderPlaced?.Invoke(notifcationMsg);
        }

        //public void OrderInStock(int orderNumber)
        //{
        //    string orderDetails = orderNumber.ToString();
        //    string messageNotification = orderDetails + DateTime.Now.ToString();
        //        OrderPlacedMethod(messageNotification);
        //}
    }
    
}
