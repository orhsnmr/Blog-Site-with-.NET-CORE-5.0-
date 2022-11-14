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
    public class ContactManager : IContactService
    {
        IContactDal ContactDal;

        public ContactManager(IContactDal contactDal)
        {
            ContactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
            ContactDal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            ContactDal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            ContactDal.Update(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return ContactDal.GetListAll();
        }


        public Contact GetByID(int ID)
        {
            return ContactDal.GetById(ID);
        }
    }
}
