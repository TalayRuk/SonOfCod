﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    [Table("Promotions")]
    public class Promotion
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image_url { get; set; }

        [MinLength(10)]
        [MaxLength(5000)]
        public string Description { get; set; }
        public virtual AdminUser User { get; set; }

    }
}
