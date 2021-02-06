using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetAll();
        Category GetById(int category);
    }
}
