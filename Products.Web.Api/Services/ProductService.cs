using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Products.Web.Api.Models;

namespace Products.Web.Api.Services
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>() 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };
        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetSingleProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            return product;
        }
    }
}