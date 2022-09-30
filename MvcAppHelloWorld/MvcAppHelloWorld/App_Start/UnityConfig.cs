using DataAccess;
using BusinessLayer;
using BusinessObjectModel;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using AutoMapper;

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

            container.RegisterType<IGenericAppService<UsersViewModel, Users>, UserAppService>();
            container.RegisterType<IGenericAppService<HighSchoolViewModel, HighSchool>, HighSchoolAppService>();
            container.RegisterType<IGenericAppService<CollegeViewModel, College>, CollegeAppService>();
            container.RegisterType<IGenericAppService<RoleViewModel, Role>, RoleAppService>();
            container.RegisterType<IGenericAppService<ProfessorViewModel, Professor>, ProfessorAppService>();

            // e.g. container.RegisterType<ITestService, TestService>();

            MapperConfiguration config = AutoMappingProfile.Configure();
            IMapper mapper = config.CreateMapper();

            container.RegisterInstance(mapper);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}