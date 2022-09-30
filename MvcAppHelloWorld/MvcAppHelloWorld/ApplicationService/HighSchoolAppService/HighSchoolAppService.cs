using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjectModel;
using BusinessLayer;
using System.Web;
using AutoMapper;

namespace MvcAppHelloWorld
{
    public class HighSchoolAppService : GenericAppService<HighSchoolViewModel, HighSchool>
    {

        public HighSchoolAppService(IGenericService<HighSchool> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }

      
    }
}