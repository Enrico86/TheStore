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

        //public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        //Con esto solo tenemos referencia solo al id del cliente y no a toda la clase Customer. 
        //Siempre que se pueda es aconsejable evitar tener referencias directas entre las diferentes clases y cuando no sea
        //necesario tener todo el conjunto de información de otro objeto (Customer) dentro de otra clase (Order) es mejor
        //utilizar solo la definición del id (eso sí, si el id de la clase Customer es un int, la propiedad CustomerId de 
        //la clase Order tendrá que ser del mismo tipo) de la clase externa

        public int ShipAddressId { get; set; }
        //Vale lo mismo que por Customer y CustomerId
    }
}
