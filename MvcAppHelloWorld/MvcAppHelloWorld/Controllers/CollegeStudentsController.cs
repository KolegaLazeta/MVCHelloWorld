using BusinessLayer;
using BusinessObjectModel;

namespace Controllers
{
    public class CollegeStudentsController : StudentsController<College>
    {
        public CollegeStudentsController(IStudentsService<College> studentsService) : base(studentsService)
        {

        }

    }
}