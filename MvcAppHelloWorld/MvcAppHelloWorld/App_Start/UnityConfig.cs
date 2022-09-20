using DataAccess;
using BusinessLayer;
using BusinessObjectModel;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MvcAppHelloWorld
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IStudentsRepository<HighSchool>, HighSchoolRepository>();
            container.RegisterType<IStudentsRepository<College>, CollegeRepository>();
            container.RegisterType<IStudentsRepository<Role>, RolesRepository>();

            container.RegisterType<IStudentsService<HighSchool>, HighSchoolService>();
            container.RegisterType<IStudentsService<College>, CollegeService>();
            container.RegisterType<IStudentsService<Role>, RolesService>();


            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}