using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.DotNetCore.Core.Service;

namespace Sandbox.DotNetCore.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICustomerService customerService;

        public HomeController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
