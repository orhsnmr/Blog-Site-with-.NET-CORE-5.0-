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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            this.message2Dal = message2Dal;
        }

        public Message2 GetByID(int ID)
        {
            return message2Dal.GetById(ID);
        }

        public List<Message2> GetInboxListByWriter(int ID)
        {
            return message2Dal.GetInBoxWithMessageByWriter(ID);
        }

        public List<Message2> GetInboxListByWriter(string p)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetList()
        {
            return message2Dal.GetListAll();
        }

        public List<Message2> GetSendboxListByWriter(int ID)
        {
            return message2Dal.GetSendBoxWithMessageByWriter(ID);
        }

        public void TAdd(Message2 t)
        {
            message2Dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
