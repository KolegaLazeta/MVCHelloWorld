using BusinessLayer;
using BusinessObjectModel;
using System.Web.Mvc;
using System.Web.Security;

namespace Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : GenericController<Role>
    {
        public RolesController(IGenericService<Role> service) : base(service)
        {

          
        }

    }
}