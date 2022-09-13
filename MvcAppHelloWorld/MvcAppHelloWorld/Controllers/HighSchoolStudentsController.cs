using BusinessObjectModel;
using BusinessLayer;

namespace Controllers
{
    public class HighSchoolStudentsController : StudentsController<HighSchool>
    {

        public HighSchoolStudentsController(IStudentsService<HighSchool> studentsService) : base(studentsService)
        {

        }

    }
}