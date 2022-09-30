﻿using AutoMapper;
using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Controllers
{
    [Authorize(Roles = "Admin,Professor")]
    public class ProfessorController : GenericController<ProfessorViewModel, Professor>
    {
        private readonly IGenericAppService<ProfessorViewModel, Professor> _professorService;
        private readonly IGenericAppService<RoleViewModel, Role> _roleService;
        public ProfessorController(IGenericAppService<ProfessorViewModel, Professor> professorService, IGenericAppService<RoleViewModel, Role> roleService, IMapper mapper) : base(professorService)
        {
            _professorService = professorService;
            _roleService = roleService;
        }

        [Authorize(Roles = "Admin")]
        public override ActionResult Save(ProfessorViewModel professor)
        {
            professor.UserRole = new List<UserRole>();

            UserRole professorRole = new UserRole
            {
                UserId = professor.UserId,
                RoleId = _roleService.GetList().FirstOrDefault(r => r.Name == "Professor").RoleId
            };
            professor.UserRole.Add(professorRole);

            _professorService.Create(professor);
            _professorService.Save();

            return RedirectToAction("Index");
        }
        public override ActionResult Details(int id)
        {
            ProfessorViewModel viewModel = _professorService.GetByID(id);
            viewModel.ReadOnly = true;
            viewModel.Title = "Details";
            viewModel.Disabled = "disabled";
            return View("Details", viewModel);
        }
        public override ActionResult Edit(int id)
        {
            ProfessorViewModel viewModel = _professorService.GetByID(id);
            viewModel.ReadOnly = false;
            viewModel.Title = "Edit";
            viewModel.Disabled = "";
            return View("Details", viewModel);
        }
    }
}