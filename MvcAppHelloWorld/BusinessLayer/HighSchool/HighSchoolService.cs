using DataAccess;
using BusinessObjectModel;

namespace BusinessLayer
{
    public class HighSchoolService : StudentsService<HighSchool>
    {
        public HighSchoolService(IStudentsRepository<HighSchool> studentsRepository) : base(studentsRepository)
        {
            
        }
    }
}
