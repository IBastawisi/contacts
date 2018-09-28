using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Model;
using Contacts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private IContactRepo contactRepo;
        public ContactController(IContactRepo _contactRepo)
        {
            this.contactRepo = _contactRepo;
        }

        [HttpGet("[action]")]
        public IEnumerable<Contact> GetAll()
        {
            return new List<Contact>();
        }

        [HttpGet("[action]")]
        public Contact Get(Guid Id)
        {
            return new Contact();
        }

        [HttpPost("[action]")]
        public IEnumerable<Contact> Add(Contact contact)
        {
            return new List<Contact>();
        }

        [HttpPut("[action]")]
        public IEnumerable<Contact> Update(Guid Id, Contact newContact)
        {
            return new List<Contact>();
        }

        [HttpPost("[action]")]
        public IEnumerable<Contact> Del(Guid Id)
        {
            return new List<Contact>();
        }

       
    }
}
