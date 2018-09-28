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
        public Guid ContactId { get; set; }
        [Required]
        public string ContacName { get; set; }
        public string ContacMail { get; set; }
        public byte[] ContactAvatar { get; set; }
        public string IsDeleted { get; set; }


        public Contact()
        {

        }
    }
}
