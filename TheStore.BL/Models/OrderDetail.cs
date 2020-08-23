using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        //Guardar
        public bool Save(OrderDetail detail)
        {
            return true;
        }

        //Obtener todos los productos
        public List<OrderDetail> GetDetails()
        {
            return new List<OrderDetail>();
        }

        //Obtener un producto por su id
        public OrderDetail GetDetail(int id)
        {
            return new OrderDetail();

        }

        //Eliminar un producto por su id
        public bool DeleteDetail(int id)
        {
            return true;
        }
    }
}
