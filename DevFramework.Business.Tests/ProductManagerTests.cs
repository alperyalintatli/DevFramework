using System;

using Devframework.Northwind.Entities.Concrete;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccess;
using DevFramework.Northwind.DataAccess.Abstract;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DevFramework.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDAL> mock = new Mock<IProductDAL>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());


        }
    }
}
