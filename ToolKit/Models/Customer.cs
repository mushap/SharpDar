using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit.Models
{
    class Customer
    {
        //public Customer()
        //{
        //    this.Orders = new List<Order>();
        //}

        public long CustomerId { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }


        public List<Order> Orders { get; set; }
    }
}
