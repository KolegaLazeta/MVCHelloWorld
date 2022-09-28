using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessObjectModel;
using BusinessLayer;

namespace MvcAppHelloWorld
{
    public class UserAppService : GenericAppService<Users>
    {
        public UserAppService(IGenericService<Users> genericService) : base(genericService)
        {

        }
    }
}