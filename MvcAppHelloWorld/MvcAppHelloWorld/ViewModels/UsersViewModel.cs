using BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppHelloWorld
{
    public class UsersViewModel : GenericViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday_date { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone_Number { get; set; }
        public string House_Address { get; set; }
        public List<Role> Role { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}