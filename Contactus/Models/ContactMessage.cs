using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contactus.Models
{
    public class ContactMessage
    {
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage ="Plese write your full name")]
        public string Username { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Your message")]
        public string Message { get; set; }
        public DateTime CreatedTimestamp { get; set; }


    }
}
