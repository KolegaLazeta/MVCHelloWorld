using AutoMapper;
using BusinessObjectModel;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppHelloWorld
{
    public class AutoMappingProfile : Profile
    {
        public static MapperConfiguration Configure()
        {
            var mapperCofiguration = new MapperConfiguration(
                config =>
                {
                    //Mapping domen modeland view model in  both directions

                    config.CreateMap<Role, RoleViewModel>();
                    config.CreateMap<RoleViewModel, Role>();

                    config.CreateMap<Users, UsersViewModel>();
                    config.CreateMap<UsersViewModel, Users>();

                    config.CreateMap<HighSchool, HighSchoolViewModel>();
                    config.CreateMap<HighSchoolViewModel, HighSchool>();

                    config.CreateMap<College, CollegeViewModel>();
                    config.CreateMap<CollegeViewModel, College>();


                    config.CreateMap<Professor, ProfessorViewModel>();
                    config.CreateMap<ProfessorViewModel, Professor>();

                    config.CreateMap<ProfessorViewModel, ProfessorQueryModel>();
                    config.CreateMap<ProfessorQueryModel, ProfessorViewModel>();

                    config.CreateMap<HighSchoolViewModel, HighSchoolStudentsQueryModel>();
                    config.CreateMap<HighSchoolStudentsQueryModel, HighSchoolViewModel>();

                    config.CreateMap<CollegeViewModel, CollegeStudentsQueryModel>();
                    config.CreateMap<CollegeStudentsQueryModel, CollegeViewModel>();

                });
            return mapperCofiguration;
        }
    }
}