using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devframework.Northwind.Entities.ComplexTypes
{
   public class ProductDetails
    {
        public virtual int ProductId { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string ProductName { get; set; }
    }
}
