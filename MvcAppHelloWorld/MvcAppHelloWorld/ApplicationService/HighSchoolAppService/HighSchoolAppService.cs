using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjectModel;
using BusinessLayer;
using System.Web;

namespace MvcAppHelloWorld
{
    public class HighSchoolAppService : GenericAppService<HighSchool>
    {
        public HighSchoolAppService(IGenericService<HighSchool> genericService) :base(genericService)
        {

        }
    }
}