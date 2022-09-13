using DataAccess;
using BusinessObjectModel;

namespace BusinessLayer
{
    public class CollegeService : StudentsService<College>
    {
        public CollegeService(IStudentsRepository<College> studentsRepository) : base(studentsRepository)
        {

        }
    }
}
