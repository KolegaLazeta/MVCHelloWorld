using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Web.Mvc;
using System.Web.Security;

namespace Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : GenericController<Role>
    {
        public RolesController(IGenericAppService<Role> service) : base(service)
        {

          
        }

    }
}