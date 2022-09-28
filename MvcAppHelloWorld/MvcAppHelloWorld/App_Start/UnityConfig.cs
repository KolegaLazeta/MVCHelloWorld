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
            container.RegisterType<IGenericRepository<HighSchool>, HighSchoolRepository>();
            container.RegisterType<IGenericRepository<College>, CollegeRepository>();
            container.RegisterType<IGenericRepository<Role>, RolesRepository>();
            container.RegisterType<IGenericRepository<Professor>, ProfesssorRepository>();
            container.RegisterType<IGenericRepository<Users>, UserRepository>();

            container.RegisterType<IGenericService<HighSchool>, HighSchoolService>();
            container.RegisterType<IGenericService<College>, CollegeService>();
            container.RegisterType<IGenericService<Role>, RolesService>();
            container.RegisterType<IGenericService<Professor>, ProfessorService>();
            container.RegisterType<IGenericService<Users>, UserService>();

            container.RegisterType<IGenericAppService<Users>, UserAppService>();
            container.RegisterType<IGenericAppService<HighSchool>, HighSchoolAppService>();
            container.RegisterType<IGenericAppService<College>, CollegeAppService>();
            container.RegisterType<IGenericAppService<Role>, RoleAppService>();
            container.RegisterType<IGenericAppService<Professor>, ProfessorAppService>();

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}