using BusinessLayer;
using BusinessObjectModel;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "Admin,Professor")]
    public class ProfessorController : GenericController<Professor>
    {
        public ProfessorController(GenericService<Professor> service) : base(service)
        {
        }
    }
}