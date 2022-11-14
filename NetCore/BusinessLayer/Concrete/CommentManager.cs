using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			this.commentDal = commentDal;
		}

		public void CommentAdd(Comment comment)
		{
			commentDal.Insert(comment);
		}

		public void CommentDelete(Comment comment)
		{
            commentDal.Delete(comment);
        }

		public void CommentUpdate(Comment comment)
		{
            commentDal.Update(comment);
        }

		public Comment GetByID(int ID)
		{
			return commentDal.GetById(ID);
		}
        public List<Comment> GetBlogByID(int ID)
        {
            return commentDal.GetListAll(x => x.BlogID == ID);
        }

		public List<Comment> GetAllComments(int ID) 
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetCommetnWithBlog()
		{
			return commentDal.GetListWithBlog();
		}

		public void TAdd(Comment t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Comment t)
		{
		  commentDal.Delete(t);
		}

		public void TUpdate(Comment t)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList()
		{
			throw new NotImplementedException();
		}
	}
}
