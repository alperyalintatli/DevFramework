using Devframework.Northwind.Entities.ComplexTypes;
using Devframework.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDAL
    {
        NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetails> GetProductDetails()
        {
            using (var session= _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>() join c in session.Query<Category>() on p.CategoryId equals c.CategoryId select new ProductDetails { CategoryName = c.CategoryName, ProductId = p.ProdutId, ProductName = p.ProductName };
                return result.ToList();
            }
        }
    }
}
