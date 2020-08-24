using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public List<OrderDetail> OrderItems { get; set; }
        public Address ShipAddress { get; set; }
        public Customer Customer { get; set; }

    }
}
