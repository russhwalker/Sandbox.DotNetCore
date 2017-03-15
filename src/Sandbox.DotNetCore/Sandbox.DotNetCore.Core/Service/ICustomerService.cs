using Sandbox.DotNetCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.DotNetCore.Core.Service
{
    public interface ICustomerService
    {
        Customer GetCustomer(int customerId);
        List<Customer> GetCustomers();
    }
}
