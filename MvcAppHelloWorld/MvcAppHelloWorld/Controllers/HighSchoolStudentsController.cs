using BusinessObjectModel;
using BusinessLayer;
using System.Web.Mvc;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using MvcAppHelloWorld;

namespace Controllers
{
    [Authorize(Roles = "HighSchool, Professor, Admin")]
    public class HighSchoolStudentsController : GenericController<HighSchool>
    {
        private readonly IGenericAppService<HighSchool> _highSchoolSrervice;
        private readonly IGenericAppService<Role> _roleService;
        public HighSchoolStudentsController(IGenericAppService<HighSchool> highSchoolService, IGenericAppService<Role> roleService) : base(highSchoolService)
        {
            _highSchoolSrervice = highSchoolService;
            _roleService = roleService;
        }

        public override ActionResult Save(HighSchool highSchool)
        {
            highSchool.UserRole = new List<UserRole>();

            UserRole userRole = new UserRole
            {
                UserId = highSchool.UserId,
                RoleId = _roleService.GetList().FirstOrDefault(ur => ur.Name == "HighSchool").RoleId
            };

            highSchool.UserRole.Add(userRole);

            _highSchoolSrervice.Create(highSchool);
            _highSchoolSrervice.Save();

            return RedirectToAction("Index");
        }

        
    }
}