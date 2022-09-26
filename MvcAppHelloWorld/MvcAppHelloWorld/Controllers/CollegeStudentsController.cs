using BusinessLayer;
using BusinessObjectModel;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "Admin, Professor")]
    public class CollegeStudentsController : GenericController<College>
    {
        public CollegeStudentsController(IGenericService<College> studentsService) : base(studentsService)
        {

        }

    }
}