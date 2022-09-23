using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectModel;

namespace DataAccess
{
    public class UserRepository : GenericRepository<Users>
    {
        public override List<Users> GetList()
        {
            using (var db = new TuxContext())
            {
                List<Users> users = db.Users.Include("UserRole").ToList();


                foreach (var user in users)
                {
                    user.UserRole = db.UserRole.Include("Role").Where(ur => ur.UserId == user.UserId).ToList();
                }
                return users;
            }

        }
    }
}
