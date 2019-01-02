using System;
using System.Collections.Generic;
using System.Text;
using ToolKit.Models;

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
}
