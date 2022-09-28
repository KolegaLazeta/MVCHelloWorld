using BusinessLayer;
using BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppHelloWorld
{
    public class ProfessorAppService : GenericAppService<Professor>
    {
        public ProfessorAppService(IGenericService<Professor> genericService) :base(genericService)
        {

        }
    }
}