﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjectModel
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public ICollection<Users> Users { get; set; }

        
    }
}
