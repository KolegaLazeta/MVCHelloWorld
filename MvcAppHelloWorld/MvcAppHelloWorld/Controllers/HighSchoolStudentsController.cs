using BusinessObjectModel;
using BusinessLayer;

namespace Controllers
{
    public class HighSchoolStudentsController : GenericController<HighSchool>
    {

        public HighSchoolStudentsController(IGenericService<HighSchool> studentsService) : base(studentsService)
        {

        }

    }
}