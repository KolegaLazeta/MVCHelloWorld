using BusinessObjectModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class UserRepository : GenericRepository<Users>
    {
        public override List<Users> GetList()
        {
            using (var db = new TuxContext())
            {
                List<Users> users = db.Users.Include(u => u.UserRole).ToList();
                foreach (var user in users)
                {
                    user.UserRole = db.UserRole.Include(ur => ur.Role).Where(ur => ur.UserId == user.UserId).ToList();
                }
                return users;
            }

        }
    }
}
