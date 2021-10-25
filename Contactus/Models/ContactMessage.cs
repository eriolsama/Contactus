using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contactus.Models
{
    public class ContactMessage
    {
        public int ID { get; set; }
        
        public string Username { get; set; }
        
        public string Message { get; set; }
    }
}
