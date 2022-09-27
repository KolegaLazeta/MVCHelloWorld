using BusinessObjectModel;
using BusinessLayer;
using System.Web.Mvc;
using System.Web.Security;

namespace Controllers
{
    [Authorize(Roles = "HighSchool, Professor, Admin")]
    public class HighSchoolStudentsController : GenericController<HighSchool>
    {

        public HighSchoolStudentsController(IGenericService<HighSchool> studentsService) : base(studentsService)
        {

        }

    }
}