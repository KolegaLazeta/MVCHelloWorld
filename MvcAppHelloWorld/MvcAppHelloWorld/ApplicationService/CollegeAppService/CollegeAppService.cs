using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using BusinessObjectModel;

namespace MvcAppHelloWorld
{
    public class CollegeAppService : GenericAppService<College>
    {
        public CollegeAppService(IGenericService<College> genericService) : base(genericService)
        {

        }
    }
}