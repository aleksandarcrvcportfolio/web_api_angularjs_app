using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Web.Api.Controllers;

namespace Products.Web.Api.Test
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void GetAllCustomers()
        {
            var prodController = new ProductsController();
            var products = prodController.GetAllProducts();
            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void Try_To_Get_Invalid_Product_Returns_Null()
        {
            var prodController = new ProductsController();
            var product = prodController.GetProduct(-1);
            Assert.IsNull(product);
        }
    }
}
