using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class CustomerRepository
    {

        //Guardar
        public bool Save(Customer customer)
        {
            return true;
        }

        //Obtener todos los clientes
        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }

        //Obtener un cliente por su id
        public Customer GetCustomer(int id)
        {
            return new Customer();

        }

        //Eliminar un cliente por su id
        public bool DeleteCustomer(int id)
        {
            return true;
        }

    }
}
