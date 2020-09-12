using Devframework.Northwind.Entities.ComplexTypes;
using Devframework.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDAL
    {
        public List<ProductDetails> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products join c in context.Categories on p.CategoryId equals c.CategoryId select new ProductDetails { ProductName = p.ProductName, ProductId = p.ProdutId,  CategoryName = c.CategoryName };
                return result.ToList();
            }
        }
    }
}
