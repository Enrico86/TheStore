using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class OrderRepository
    {
        private List<Order> OrdersData = new List<Order>();
        private OrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        //Guardar
        public bool Save(Order newOrder)
        {
            if (newOrder.OrderItems.Count==0)
            {
                throw new Exception("No se puede crear un pedido sin DetallesPedido");
            }
            if (newOrder.ShipAddressId==0)
            {
                throw new Exception("No se puede crear un pedido con id de Dirección de envío igual a 0");
            }
            if (newOrder.CustomerId==0)
            {
                throw new Exception("No se puede crear un pedido con el id del Cliente igual a 0");
            }
            OrdersData.Insert(OrdersData.Count, newOrder);
            foreach (var orderItem in newOrder.OrderItems)
            {
                orderDetailRepository.InsertOrderDetail(orderItem);
            }
            return true;
        }

        //Obtener todos los pedidos en la bbdd
        public List<Order> GetOrders()
        {
            foreach (var order in OrdersData)
            {
                order.OrderItems = orderDetailRepository.GetDetailsByOrderId(order.Id);
            }
            return OrdersData;
        }

        //Obtener un pedido por su id
        public Order GetOrderById(int orderId)
        {
            Order order = OrdersData.FirstOrDefault(o => o.Id == orderId);
            order.OrderItems = orderDetailRepository.GetDetailsByOrderId(orderId);
            return order;
        }

        //Eliminar un pedido por su id
        public bool DeleteOrder(int orderId)
        {
            var orderToDelete = OrdersData.FirstOrDefault(o => o.Id == orderId);
            if (orderToDelete!=null)
            {
                OrdersData.Remove(orderToDelete);
                foreach(var orderDetail in orderToDelete.OrderItems)
                {
                    orderToDelete.OrderItems.Remove(orderDetail);
                }
                return true;
            }
            return false;
        }
    }
}
