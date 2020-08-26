using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Models
{
    public class SilverCustomer: Customer
    {
        public int RemainingPurchases { get; set; }
    }
}
