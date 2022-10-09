using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class CollegeStudentsQueryRepository : GenericRepository<CollegeStudentsQueryModel>
    {
        public override List<CollegeStudentsQueryModel> GetList()
        {
            using (var db = new TuxContext())
            {
                var query = @"
                        SELECT *
                        FROM Users
                        INNER JOIN Role on Users.TypeOfUser = Role.Name
                        INNER JOIN UserRole on Users.UserId = UserRole.UserId
                        WHERE UserRole.RoleId = 4
                        ";
                var colelgeStudentsList = db.Database.SqlQuery<CollegeStudentsQueryModel>(query).ToList();
                return colelgeStudentsList;
            }
        }
    }
}
