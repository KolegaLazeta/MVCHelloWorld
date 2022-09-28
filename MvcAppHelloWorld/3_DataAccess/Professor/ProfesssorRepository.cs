using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectModel;

namespace DataAccess
{
    public class ProfesssorRepository : GenericRepository<Professor>
    {
        private TuxContext db = null;

        public ProfesssorRepository()
        {
            this.db = new TuxContext();
        }

        public override List<Professor> GetList()
        {
            return db.Professor.Include("UserRole").ToList();
        }

        public override void Create(Professor professor)
        {
            db.Users.Add(professor);
            db.UserRole.AddRange(professor.UserRole);
            db.SaveChanges();
        }
        public override void Delete(int id)
        {
            var userRoles = db.UserRole.Where(ur => ur.UserId == id);
            db.UserRole.RemoveRange(userRoles);
            db.Users.Remove(GetByID(id));
            db.SaveChanges();
        }

    }
}
