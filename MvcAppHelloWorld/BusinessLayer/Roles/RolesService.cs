using BusinessObjectModel;
using DataAccess;

namespace BusinessLayer
{
    public class RolesService : StudentsService<Role>
    {
        public RolesService(IStudentsRepository<Role> service) : base(service)
        {

        }
    }
}
