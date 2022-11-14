using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService : IGenericService<Comment>
    {
		void CommentAdd(Comment comment);
		void CommentDelete(Comment comment);
		void CommentUpdate(Comment comment);
		List<Comment> GetAllComments(int ID);
		List<Comment> GetCommetnWithBlog();
		Comment GetByID(int ID);
	}
}
