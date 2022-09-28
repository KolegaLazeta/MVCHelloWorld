using BusinessLayer;
using BusinessObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "Admin,Professor")]
    public class ProfessorController : GenericController<Professor>
    {
        private readonly IGenericService<Professor> _professorService;
        private readonly IGenericService<Role> _roleService;
        public ProfessorController(GenericService<Professor> professorService, IGenericService<Role> roleService) : base(professorService)
        {
            _roleService = roleService;
            _professorService = professorService;
        }

        [Authorize(Roles = "Admin")]
        public override ActionResult Save(Professor professor)
        {
            professor.UserRole = new List<UserRole>();

            UserRole professorRole = new UserRole
            {
                UserId = professor.UserId,
                RoleId = _roleService.GetList().FirstOrDefault(r=> r.Name == "Professor").RoleId
            };
            professor.UserRole.Add(professorRole);

            _professorService.Create(professor);
            _professorService.Save();

            return RedirectToAction("Index");
        }
    }
}