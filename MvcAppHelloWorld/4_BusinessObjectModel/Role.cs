using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BusinessObjectModel
{
    public class Role 
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<Users> Users { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}
