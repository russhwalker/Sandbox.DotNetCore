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
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

    }
}
