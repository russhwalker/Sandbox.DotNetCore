using Sandbox.DotNetCore.Core.Repository;
using System;
using Sandbox.DotNetCore.Core.Models;
using System.Collections.Generic;

namespace Sandbox.DotNetCore.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        public Customer GetCustomer(int customerId)
        {
            return new Customer
            {
                CustomerId = customerId,
                FirstName = "John",
                LastName = "Doe"
            };
        }

        public List<Customer> GetCustomers()
        {
            //mock data for now
            return new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    FirstName="John",
                    LastName ="Doe"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName="Jane",
                    LastName ="Smith"
                }
            };
        }

    }
}
