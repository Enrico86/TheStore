using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TheStore.BL.Models;
using TheStore.BL.Services;

namespace TheStore.BL.Repositories
{
    public class CustomerRepositoryList:ICustomerRepository
    {
        private List<Customer> CustomersData = new List<Customer>();
        private AddressRepository addressRepository = new AddressRepository();

        //Guardar
        public bool Save(Customer newCustomer)
        {
            if (newCustomer.Addresses.Count==0)
            {
                throw new Exception("No se puede introducir un cliente sin direcciones");
            }
            CustomersData.Insert(CustomersData.Count, newCustomer);
            foreach (var address in newCustomer.Addresses)
            {
                addressRepository.InsertAddress(address);
            }
            return true;
        }

        //Obtener todos los clientes con sus direcciones
        public List<Customer> GetAll()
        {
            foreach (var customer in CustomersData)
            {
                customer.Addresses = addressRepository.GetAddressesByCustomerId(customer.Id);
            }
            return CustomersData;
        }

        //Obtener un cliente por su id
        public Customer GetById(int id)
        {
            Customer customer = new Customer();
            customer = CustomersData.FirstOrDefault(c => c.Id == id);
            customer.Addresses = addressRepository.GetAddressesByCustomerId(id);
            return customer; 

        }

        //Eliminar un cliente por su id
        public bool Delete(int customerId)
        {
            var customerToDelete = GetById(customerId);
            if (customerToDelete!=null)
            { 
            CustomersData.Remove(customerToDelete);
                foreach (var address in customerToDelete.Addresses)
                {
                    customerToDelete.Addresses.Remove(address);
                }
                return true;
            }
            return false;
        }

    }
}
