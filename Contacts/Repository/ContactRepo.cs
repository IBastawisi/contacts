using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Model;

namespace Contacts.Repository
{
    public class ContactRepo : IContactRepo
    {
        //enum StatusCode { OK = 1, Error = -1 };

        private Context contactDb;

        public ContactRepo()
        {
            contactDb = new Context();
        }

        public IEnumerable<Contact> GetAll ()
        {
            throw new NotImplementedException();
        }

        public Contact Get(Guid Id)
        {
            try
            {
                Contact contact = contactDb.Contacts.FirstOrDefault(c => c.ContactId == Id);

                if (contact != null)
                {
                    return contact;
                }
                else
                {
                    return new Contact();
                }
            }
            catch (Exception)
            {

                return new Contact();
            }
        }

        public IEnumerable<Contact> Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> Update(Guid Id, Contact newContact)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact>  Delete(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
