using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Services
{
    public interface ICustomerRepository
    {
        bool Save(Customer newCustomer);
        List<Customer> GetAll();
        Customer GetById(int customerId);
        bool Delete(int customerId);
    }
}
