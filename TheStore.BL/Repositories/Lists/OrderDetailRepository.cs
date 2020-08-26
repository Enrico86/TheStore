using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class OrderDetailRepository
    {
        private List<OrderDetail> OrderDetails = new List<OrderDetail>();
        //Con este enfoque los repositorios están fuertemente ligados con estas listas de objetos, por lo que
        //resulta complicado utilizarlo con bbdd, archivos excel, etc.
        //Podríamos pensar crear un repositorio base y clases hijas, pero no nos serviría en este escenario ya que cada 
        //escenario tiene su forma de trabajar. Por lo tanto, tendríamos que crear clases repositorios y que una ataque
        //a la tecnología con la que deseemos trabajar?
        //No, podemos utilizar clases abstractas e interfaces para resolver esta problematica.

        private ProductRepository productRepository = new ProductRepository();

        //Guardar un detalle (línea) de un pedido
        public bool InsertOrderDetail(OrderDetail newOrderDetail)
        {
            OrderDetails.Insert(OrderDetails.Count, newOrderDetail);
            return true;
        }


        //Obtener los detalles de un pedido según el id del pedido
        public List<OrderDetail> GetDetailsByOrderId(int orderId)
        {
            OrderDetails = new List<OrderDetail>()
            {
                new OrderDetail()
                {
                    Id=1,
                    Product= productRepository.GetProductById(1),
                    PurchasePrice=1.25m,
                    Quantity=2
                },
                new OrderDetail
                {
                    Id=2,
                    Product=productRepository.GetProductById(2),
                    PurchasePrice=2.5m,
                    Quantity=1
                }
            };
            return OrderDetails;

        }
    }
}
