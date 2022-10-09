using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ProfessorQueryRepository : GenericRepository<ProfessorQueryModel>
    {
        public override List<ProfessorQueryModel> GetList()
        {
            using (var db = new TuxContext())
            {

                var query = @"
                        SELECT *
                        FROM Users
                        INNER JOIN Role on Users.TypeOfUser = Role.Name
                        INNER JOIN UserRole on Users.UserId = UserRole.UserId
                        Where Cabinet  IS NOT NULL and ClassSubject is not null
                        ";
                var professorList = db.Database.SqlQuery<ProfessorQueryModel>(query).ToList();

                return professorList;
            }
        }
    }
}
