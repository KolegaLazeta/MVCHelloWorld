using BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppHelloWorld
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<Users> Users { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}