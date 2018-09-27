using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Model;

namespace Contacts.Repository
{
    public class ContactRepo : IContactRepo
    {
        enum StatusCode { OK = 1, Error = -1 };

        private Context contactDb;

        public ContactRepo()
        {
            contactDb = new Context();
        }

        public IEnumerable<Contact> GetContactList()
        {
            throw new NotImplementedException();
        }

        public Contact GetContact(Guid Id)
        {
            try
            {
                Contact contact = contactDb.Contacts.FirstOrDefault(c => c.contactId == Id);

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

        public int AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int DeleteContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
