using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Model
{

    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid contactId { get; set; }
        [Required]
        public string contacName { get; set; }
        public string contacMail { get; set; }
        public byte[] contactAvatar { get; set; }
        public string IsDeleted { get; set; }

    }
}
