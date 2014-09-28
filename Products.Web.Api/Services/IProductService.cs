using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Products.Web.Api.Models;

namespace Products.Web.Api.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetSingleProduct(int id);
    }
}