using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectModel
{
    public class Professor : Users
    {
        public string ClassSubject { get; set; }
        public string Cabinet { get; set; }
    }
}
