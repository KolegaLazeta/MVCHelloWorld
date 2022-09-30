﻿using BusinessObjectModel;
using BusinessLayer;
using System.Web.Mvc;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using MvcAppHelloWorld;

namespace Controllers
{
    [Authorize(Roles = "HighSchool, Professor, Admin")]
    public class HighSchoolStudentsController : GenericController<HighSchoolViewModel, HighSchool>
    {
        private readonly IGenericAppService<HighSchoolViewModel, HighSchool> _highSchoolService;
        private readonly IGenericAppService<RoleViewModel, Role> _roleAppService;
        public HighSchoolStudentsController(IGenericAppService<HighSchoolViewModel, HighSchool> highSchoolService, IGenericAppService<RoleViewModel,Role> roleService) : base(highSchoolService)
        {
            _highSchoolService = highSchoolService;
            _roleAppService = roleService;
        }

        public override ActionResult Save(HighSchoolViewModel highSchool)
        {
            highSchool.UserRole = new List<UserRole>();

            UserRole userRole = new UserRole
            {
                UserId = highSchool.UserId,
                RoleId = _roleAppService.GetList().FirstOrDefault(ur => ur.Name == "HighSchool").RoleId
            };

            highSchool.UserRole.Add(userRole);

            _highSchoolService.Create(highSchool);
            _highSchoolService.Save();

            return RedirectToAction("Index");
        }


        // ne prikazuje podatke
        public override ActionResult Details(int id)
        {
            HighSchoolViewModel viewModel = _highSchoolService.GetByID(id);
            viewModel.ReadOnly = true;
            viewModel.Title = "Details";
            viewModel.Disabled = "disabled";
            return View("Details", viewModel);
        }
        public override ActionResult Edit(int id)
        {
            HighSchoolViewModel viewModel = _highSchoolService.GetByID(id);
            viewModel.ReadOnly = false;
            viewModel.Title = "Edit";
            viewModel.Disabled = "";
            return View("Details", viewModel);
        }

    }
}