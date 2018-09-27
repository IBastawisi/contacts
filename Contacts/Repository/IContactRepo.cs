using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Repository
{
    public interface IContactRepo
    {
        IEnumerable<Contact> GetContactList();
        Contact GetContact(Guid Id);

        int AddContact(Contact contact);
        int UpdateContact(Contact contact);
        int DeleteContact(Contact contact);

    }
}
