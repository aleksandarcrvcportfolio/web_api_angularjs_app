using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Products.Web.Api.Models;
using Products.Web.Api.Services;

namespace Products.Web.Api.Controllers
{
    [EnableCors("*", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        public IEnumerable<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = _productService.GetSingleProduct(id);
            if (product == null)
            {
                return null;
            }
            return Ok(product);
        }
    }
}
