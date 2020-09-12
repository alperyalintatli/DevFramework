using Devframework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById (int id);
        Category Add(Category category);
    }
}
