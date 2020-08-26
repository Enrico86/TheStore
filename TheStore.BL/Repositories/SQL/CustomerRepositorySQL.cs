using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TheStore.BL.Models;
using TheStore.BL.Services;

namespace TheStore.BL.Repositories.SQL
{
    public class CustomerRepositorySQL : ICustomerRepository
    {
        public bool Delete(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            var command = new SqlCommand("select * ...",
                new SqlConnection("connection"));
            var reader = command.ExecuteReader();
            while (reader!=null)
            {
                var customer = new Customer();
                customers.Add(customer);
            }
            return customers;
        }

        public Customer GetById(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool Save(Customer newCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
