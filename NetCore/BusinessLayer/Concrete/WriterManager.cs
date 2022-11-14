using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			this.writerDal = writerDal;
		}

		public Writer GetByID(int ID)
		{
			return writerDal.GetById(ID);
		}

		public List<Writer> GetList()
		{
			throw new NotImplementedException();
		}

		public List<Writer> GetWriterByID(int ID)
		{
			return writerDal.GetListAll(x=>x.WriterID == ID);
		}

		public void TAdd(Writer t)
		{
            writerDal.Insert(t);
        }

		public void TDelete(Writer t)
		{
			writerDal.Delete(t);
		}

		public void TUpdate(Writer t)
		{
			writerDal.Update(t);
		}
	}
}
