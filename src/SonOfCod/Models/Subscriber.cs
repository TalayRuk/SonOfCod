using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    [Table("Subscribers")]
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Company { get; set; }
        public string Consumer_type { get; set; }
        public virtual AdminUser User { get; set; }
    }
}
