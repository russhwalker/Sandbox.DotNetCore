using Sandbox.DotNetCore.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Sandbox.DotNetCore.Core.Models;
using Sandbox.DotNetCore.Core.Repository;

namespace Sandbox.DotNetCore.Business.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


    }
}
