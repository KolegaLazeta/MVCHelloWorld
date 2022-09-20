using BusinessLayer;
using BusinessObjectModel;

namespace Controllers
{
    public class CollegeStudentsController : GenericController<College>
    {
        public CollegeStudentsController(IGenericService<College> studentsService) : base(studentsService)
        {

        }

    }
}