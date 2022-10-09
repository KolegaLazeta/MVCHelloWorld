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
                        SELECT *
                        FROM Users
                        INNER JOIN Role on Users.TypeOfUser = Role.Name
                        INNER JOIN UserRole on Users.UserId = UserRole.UserId
                        WHERE UserRole.RoleId = 6
                        ";
                var highSchoolStudentsList = db.Database.SqlQuery<HighSchoolStudentsQueryModel>(query).ToList();
                return highSchoolStudentsList;
            }
        }
    }
}
