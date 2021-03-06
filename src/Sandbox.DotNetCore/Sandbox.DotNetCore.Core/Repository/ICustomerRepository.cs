﻿using Sandbox.DotNetCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.DotNetCore.Core.Repository
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int customerId);
        List<Customer> GetCustomers();
    }
}
