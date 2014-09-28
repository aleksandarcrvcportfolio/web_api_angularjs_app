using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Web.Api.Controllers;
using Products.Web.Api.Models;
using Products.Web.Api.Services;
using Moq;

namespace Products.Web.Api.Test
{
    [TestClass]
    public class ProductsControllerTest
    {
        ProductsController _productController;
        Mock<IProductService> _mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new Mock<IProductService>();
            _productController = new ProductsController(_mockRepository.Object);
        }

        [TestMethod]
        public void ShouldLoadAllProducts()
        {
            _mockRepository.Setup(r => r.GetAllProducts()).Returns(new List<Product>()
            {
                new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
                new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
                new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
            });
            var returnedProducts = _productController.GetAllProducts();
            Assert.AreEqual(returnedProducts.Count(), 3);
            _mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Should_Load_Single_Product()
        {
            _mockRepository.Setup(r => r.GetSingleProduct(It.IsAny<int>()))
                .Returns(new Product() { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            var product = _productController.GetProduct(1);
            Assert.IsNotNull(product);
        }
    }
}
