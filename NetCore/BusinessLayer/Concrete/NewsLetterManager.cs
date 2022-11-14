using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal LetterDal;

        public NewsLetterManager(INewsLetterDal letterDal)
        {
            LetterDal = letterDal;
        }

        public void NewsLetterAdd(NewsLetter newsLetter)
        {
            LetterDal.Insert(newsLetter);
        }
    }
}
