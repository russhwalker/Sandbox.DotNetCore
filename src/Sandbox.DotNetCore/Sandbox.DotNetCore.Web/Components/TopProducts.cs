using Microsoft.AspNetCore.Mvc;
using Sandbox.DotNetCore.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.DotNetCore.Web.Components
{
    public class TopProducts : ViewComponent
    {
        private readonly IProductService productService;

        public TopProducts(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var viewModel = new ViewModels.TopProductsViewModel
            {

            };
            return View(viewModel);
        }

    }
}
