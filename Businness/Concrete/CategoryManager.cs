﻿using Businness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            // iŞ KODLARI YAZILIR.
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Category> ICategoryService.GetById(int category)
        {
            throw new NotImplementedException();
        }
    }
}
