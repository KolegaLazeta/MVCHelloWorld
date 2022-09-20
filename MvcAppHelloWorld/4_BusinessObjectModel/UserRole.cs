using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjectModel
{
    public class UserRole
    {
        [ForeignKey("UserId")]
        public ICollection<Users> Users { get; set; }
        public int UserId { get; set; }
        [ForeignKey("RoleId")]
        public ICollection<Roles> Roles { get; set; }
        public int RoleId { get; set; }
    }
}
