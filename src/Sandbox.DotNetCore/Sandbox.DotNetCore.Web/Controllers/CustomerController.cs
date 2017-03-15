using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.DotNetCore.Core.Service;

namespace Sandbox.DotNetCore.Web.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            var viewModel = new ViewModels.CustomersViewModel
            {
                Customers = this.customerService.GetCustomers()
            };
            return View(viewModel);
        }

        public IActionResult Edit(int customerId)
        {
            var viewModel = new ViewModels.CustomerViewModel
            {
                Customer = this.customerService.GetCustomer(customerId)
            };
            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
