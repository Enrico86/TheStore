using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class OrderRepository
    {
        //Guardar
        public bool Save(Order order)
        {
            return true;
        }

        //Obtener todos los pedido
        public List<Order> GetOrders()
        {
            return new List<Order>();
        }

        //Obtener un pedido por su id
        public Order GetOrders(int id)
        {
            return new Order();

        }

        //Eliminar un pedido por su id
        public bool DeleteOrder(int id)
        {
            return true;
        }
    }
}
