using BusinessLayer;
using BusinessObjectModel;
namespace Controllers
{
    public class ProfessorController : GenericController<Professor>
    {
        public ProfessorController(GenericService<Professor> service) : base(service)
        {
        }
    }
}