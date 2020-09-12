using Devframework.Northwind.Entities.ComplexTypes;
using Devframework.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Abstract
{
   public interface IProductDAL:IEntityRepository<Product>
    {
        List<ProductDetails> GetProductDetails();
    }
}
