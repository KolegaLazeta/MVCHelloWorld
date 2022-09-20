using BusinessLayer;
using BusinessObjectModel;

namespace Controllers
{
    public class RolesController : StudentsController<Role>
    {
        public RolesController(IStudentsService<Role> service) : base(service)
        {

        }

    }
}