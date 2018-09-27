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
        public IEnumerable<Contact> ContactList()
        {
            return new List<Contact>();
        }

       
    }
}
