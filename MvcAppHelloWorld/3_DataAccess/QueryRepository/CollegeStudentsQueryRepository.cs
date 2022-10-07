using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CollegeStudentsQueryRepository : GenericRepository<CollegeStudentsQueryModel>
    {
        public override List<CollegeStudentsQueryModel> GetList()
        {
            using (var db = new TuxContext())
            {
                var query = @"
                        SELECT UserId, Name, LastName, Birthday_date, College_Name, Generation_of_Student
                        FROM Users
                        WHERE Generation_of_Student  IS NOT NULL and College_Name IS NOT NULL
                        ";
                var colelgeStudentsList = db.Database.SqlQuery<CollegeStudentsQueryModel>(query).ToList();

                foreach (var student in colelgeStudentsList)
                {
                    student.UserRoles = db.UserRole.Include("Role").Where(ur => ur.UserId == student.UserId).ToList();
                }

                return colelgeStudentsList;
            }
        }
    }
}
