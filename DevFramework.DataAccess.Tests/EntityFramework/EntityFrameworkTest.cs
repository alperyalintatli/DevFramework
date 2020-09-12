using System;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.DataAccess.Tests.EntityFramework
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void get_all_return_all_product()
        {
            EfProductDal productDal = new EfProductDal();
            var result=productDal.GetList();

            Assert.AreEqual(80,result.Count);

        }

        [TestMethod]
        public void get_all_with_parameter_return_filtered_product()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);

        }
    }
}
