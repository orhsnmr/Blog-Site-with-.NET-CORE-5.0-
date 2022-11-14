using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogByID(int ID)
        {
            return blogDal.GetListAll(x=>x.BlogID == ID);
        }
        public Blog GetByID(int ID)
        {
            return blogDal.GetById(ID);
        }

        public List<Blog> GetList()
        {
           return blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetListWithCategoryByWriterBm(int ID)
        {
            return blogDal.GetListWithCategoryByWriter(ID);
        }
        public List<Blog> GetBlogByWriter(int ID)
        {
            return blogDal.GetListAll(x=>x.WriterID == ID); 
        }

        public void TAdd(Blog t)
        {
            blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            blogDal.Update(t);
        }
    }
}
