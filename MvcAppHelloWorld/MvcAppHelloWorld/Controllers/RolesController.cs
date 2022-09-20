using BusinessLayer;
using BusinessObjectModel;

namespace Controllers
{
    public class RolesController : StudentsController<Roles>
    {
        public RolesController(IStudentsService<Roles> service) : base(service)
        {

        }

    }
}