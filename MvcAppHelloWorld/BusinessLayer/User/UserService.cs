using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectModel;
using DataAccess;

namespace BusinessLayer
{
    public class UserService : GenericService<Users>
    {
        public UserService(IGenericRepository<Users> repository): base(repository)
        {

        }
    }
}
