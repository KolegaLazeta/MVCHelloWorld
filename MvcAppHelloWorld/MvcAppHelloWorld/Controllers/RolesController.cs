using AutoMapper;
using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Web.Mvc;
using System.Web.Security;

namespace Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : GenericController<RoleViewModel, Role>
    {

        public RolesController(IGenericAppService<RoleViewModel, Role> roleService) : base(roleService)
        {
        }

    }
}