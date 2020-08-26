using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Models
{
    public class GoldCustomer: Customer
    {
        public float Discount { get; set; }
        public List<string> DiscountCupons { get; set; }
    }
}
