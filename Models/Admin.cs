﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyCore.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName ="Varchar(20)")]
        public string UserName { get; set; }
        [Column(TypeName = "Varchar(15)")]
        public string Password { get; set; }
    }
}
