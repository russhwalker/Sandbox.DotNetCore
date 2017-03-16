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
        

        public HomeController()
        {
        }

        public IActionResult Index()
        {

            return View();
        } 

        public IActionResult Error()
        {
            return View();
        }
    }
}
