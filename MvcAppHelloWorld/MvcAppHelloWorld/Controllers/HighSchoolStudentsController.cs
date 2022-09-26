using BusinessObjectModel;
using BusinessLayer;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "Admin, Professor")]
    public class HighSchoolStudentsController : GenericController<HighSchool>
    {

        public HighSchoolStudentsController(IGenericService<HighSchool> studentsService) : base(studentsService)
        {

        }

    }
}