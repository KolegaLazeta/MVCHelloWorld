using BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcAppHelloWorld
{
    public class RoleViewModel : GenericViewModel
    {
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Filed is required")]
        public string Name { get; set; }
    }
}