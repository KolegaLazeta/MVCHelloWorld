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
                        SELECT UserId, Name, LastName, Birthday_date, Cabinet, ClassSubject
                        FROM Users
                        Where Cabinet  IS NOT NULL and ClassSubject is not null
                        ";
                var professorList = db.Database.SqlQuery<ProfessorQueryModel>(query).ToList();

                foreach (var professor in professorList)
                {
                    professor.UserRoles = db.UserRole.Include("Role").Where(ur => ur.UserId == professor.UserId).ToList();
                }

                return professorList;
            }
        }
    }
}
