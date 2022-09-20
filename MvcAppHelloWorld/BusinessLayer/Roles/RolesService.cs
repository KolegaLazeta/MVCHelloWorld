using BusinessObjectModel;
using DataAccess;

namespace BusinessLayer
{
    public class RolesService : StudentsService<Roles>
    {
        public RolesService(IStudentsRepository<Roles> service) : base(service)
        {

        }
    }
}
