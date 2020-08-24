using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }



    }
}
