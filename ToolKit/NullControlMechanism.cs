using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKit
{
    class NullControlMechanism
    {
        public string NullableControl()
        {
            Customer customer = new Customer();
            //if customer is null this method dont go check orders,orders[0] vs direct return null(this method make your code short, fast and clear)
            string isNull = customer?.Orders?[0]?.OrderDetails?[0].OrderDetailName;
            return isNull;
        }
    }

    //for usage in above method
    public class Customer
    {
        //public Customer()
        //{
        //    this.Orders = new List<Order>();
        //}

        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        //public Order()
        //{
        //    this.OrderDetails = new List<OrderDetails>();
        //}
        public List<OrderDetails> OrderDetails { get; set; }
    }

    public class OrderDetails
    {
        public string OrderDetailName { get; set; }
    }

}
