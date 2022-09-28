using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "Admin,Professor")]
    public class ProfessorController : GenericController<Professor>
    {
        private readonly IGenericAppService<Professor> _professorService;
        private readonly IGenericAppService<Role> _roleService;
        public ProfessorController(IGenericAppService<Professor> professorService, IGenericAppService<Role> roleService) : base(professorService)
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