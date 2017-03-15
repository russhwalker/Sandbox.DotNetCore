using Sandbox.DotNetCore.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Sandbox.DotNetCore.Core.Models;
using Sandbox.DotNetCore.Core.Repository;

namespace Sandbox.DotNetCore.Business.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public List<Customer> GetCustomers()
        {
            return this.customerRepository.GetCustomers();
        }

        public Customer GetCustomer(int customerId)
        {
            return this.customerRepository.GetCustomer(customerId);
        }

    }
}
