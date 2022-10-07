using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class HighSchoolStudentsQueryRepository : GenericRepository<HighSchoolStudentsQueryModel>
    {
        public override List<HighSchoolStudentsQueryModel> GetList()
        {
            using (var db = new TuxContext())
            {
                var query = @"
                        SELECT UserId, Name, LastName, Birthday_date, School_Name, Enrollment_Date
                        FROM Users
                        Where Enrollment_Date  IS NOT NULL and School_Name is not null
                        ";
                var highSchoolStudentsList = db.Database.SqlQuery<HighSchoolStudentsQueryModel>(query).ToList();

                foreach (var student in highSchoolStudentsList)
                {
                    student.UserRoles = db.UserRole.Include("Role").Where(ur => ur.UserId == student.UserId).ToList();
                }

                return highSchoolStudentsList;
            }
        }
    }
}
