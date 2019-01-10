using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit.Models
{
    public class Customer
    {
        //public Customer()
        //{
        //    this.Orders = new List<Order>();
        //}
        public Customer()
        {

        }
        public Customer(long customerId, String Name)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
        }

        public long CustomerId { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }

        private string _code { get; set; }

        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = Code;
            }
        }

        public List<Order> Orders { get; set; }

        public static List<Customer> CreateCustomerData()
        {
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 10; i++)
            {
                customers.Add(new Customer
                {
                    CustomerId = i,
                    Name = $"Customer-{i}",
                    OrderNo = 1
                });
            }

            return customers;
        }
    }
}
