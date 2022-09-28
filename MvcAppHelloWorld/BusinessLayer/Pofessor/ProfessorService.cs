using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectModel;
using DataAccess;

namespace BusinessLayer
{
    public class ProfessorService : GenericService<Professor>
    {
        public ProfessorService(GenericRepository<Professor> repository) : base(repository)
        {

        }
    }
}
