﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public Category GetByID(int ID)
        {
            return categoryDal.GetById(ID);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            categoryDal.Update(t);
        }
    }
}
