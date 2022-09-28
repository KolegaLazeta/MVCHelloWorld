using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "College, Professor, Admin")]
    public class CollegeStudentsController : GenericController<College>
    {
        private readonly IGenericAppService<College> _collegeSrervice;
        private readonly IGenericAppService<Role> _roleService;
        public CollegeStudentsController(IGenericAppService<College> collegeService, IGenericAppService<Role> roleService) : base(collegeService)
        {
            _collegeSrervice = collegeService;
            _roleService = roleService;
        }

        public override ActionResult Save(College college)
        {
            college.UserRole = new List<UserRole>();

            var userRole = new UserRole
            {
                UserId = college.UserId,
                RoleId = _roleService.GetList().FirstOrDefault(ur => ur.Name == "Professor").RoleId
            };

            college.UserRole.Add(userRole);

            _collegeSrervice.Create(college);
            _collegeSrervice.Save();
            return RedirectToAction("Index");

        }
    }
}