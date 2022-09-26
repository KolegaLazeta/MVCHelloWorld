using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using DataAccess;

namespace Infrastructure
{
    public class AppRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (var db = new TuxContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Email == username); // looking for user with this email
                var userRoles = db.Role.Select(r => r.Name); // joining Role entitet using Name property

                if (user == null)
                    return new string[] { }; //return blank string
                return user.Role == null ? new string[] { } : 
                    userRoles.ToArray(); // else, create array of users with roles

            }
        }


        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            using(var db  = new TuxContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Email == username);
                var userRoles = db.Role.Select(r => r.Name);


                if (user == null)
                    return false;
                return user.Role != null && userRoles.Any(r => r == roleName); // else, 
            }
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
