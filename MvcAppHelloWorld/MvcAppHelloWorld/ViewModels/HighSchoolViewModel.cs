using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessObjectModel;
using DataAccess;

namespace MvcAppHelloWorld
{
    public class HighSchoolViewModel
    {
        public Users Users { get; set; }
        public HighSchool HighSchool { get; set; }
        public string TitleForDetail { get; set; }
        public string TitleForEdit { get; set; }

    }
}