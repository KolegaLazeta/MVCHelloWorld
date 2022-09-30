using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "College, Professor, Admin")]
    public class CollegeStudentsController : GenericController<CollegeViewModel, College>
    {
        private readonly IGenericAppService<CollegeViewModel, College> _collegeService;
        private readonly IGenericAppService<RoleViewModel, Role> _roleService;
        public CollegeStudentsController(IGenericAppService<CollegeViewModel, College> collegeService, IGenericAppService<RoleViewModel, Role> roleService) : base(collegeService)
        {
            _collegeService = collegeService;
            _roleService = roleService;
        }

        public override ActionResult Save(CollegeViewModel college)
        {
            college.UserRole = new List<UserRole>();

            var userRole = new UserRole
            {
                UserId = college.UserId,
                RoleId = _roleService.GetList().FirstOrDefault(ur => ur.Name == "Professor").RoleId
            };

            college.UserRole.Add(userRole);

            _collegeService.Create(college);
            _collegeService.Save();
            return RedirectToAction("Index");

        }
        public override ActionResult Details(int id)
        {
            CollegeViewModel viewModel = _collegeService.GetByID(id);
            viewModel.ReadOnly = true;
            viewModel.Title = "Details";
            viewModel.Disabled = "disabled";
            return View("Details", viewModel);
        }
        public override ActionResult Edit(int id)
        {
            CollegeViewModel viewModel = _collegeService.GetByID(id);
            viewModel.ReadOnly = false;
            viewModel.Title = "Edit";
            viewModel.Disabled = "";
            return View("Details", viewModel);
        }
    }
}