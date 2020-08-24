using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class OrderDetailRepository
    {
        //Guardar un detalle (línea) de un pedido
        public bool Save(OrderDetail detail)
        {
            return true;
        }

        //Obtener todos los detalles (líneas) de un pedido
        public List<OrderDetail> GetDetails()
        {
            return new List<OrderDetail>();
        }

        //Obtener un detalle (línea) por su id
        public OrderDetail GetDetail(int id)
        {
            return new OrderDetail();

        }

        //Eliminar un detalle (línea) por su id
        public bool DeleteDetail(int id)
        {
            return true;
        }
    }
}
