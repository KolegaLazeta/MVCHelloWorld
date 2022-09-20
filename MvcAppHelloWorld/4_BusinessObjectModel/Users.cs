using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjectModel
{

    [Table("Users")]
    public class Users
        // Base Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Birthday_date { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Phone_Number { get; set; }
        public string House_Address { get; set; }

        public List<Roles> Roles { get; set; }

        public Users()
        {
            var roles = new Roles();
            roles.RoleId = 1;
            roles.Name = "HighSchool";
            
        }

        
    }

}
