using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Repository
{
    public interface IContactRepo
    {
        IEnumerable<Contact> GetAll();
        Contact Get(Guid Id);
        IEnumerable<Contact> Add(Contact contact);
        IEnumerable<Contact> Update(Guid Id, Contact newContact);
        IEnumerable<Contact> Delete(Guid Id);

    }
}
