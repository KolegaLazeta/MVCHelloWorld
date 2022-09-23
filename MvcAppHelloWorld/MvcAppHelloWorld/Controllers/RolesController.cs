using BusinessLayer;
using BusinessObjectModel;

namespace Controllers
{
    public class RolesController : GenericController<Role>
    {
        public RolesController(IGenericService<Role> service) : base(service)
        {
        }
    }
}