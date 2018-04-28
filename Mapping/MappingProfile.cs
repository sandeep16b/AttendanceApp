using AutoMapper;
using MyApp.Controllers.Resources;
using MyApp.Models;

namespace MyApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Division, DivisionResource>();
            CreateMap<Location, LocationResource>();
            CreateMap<Category, CategoryResource>();
            CreateMap<Class, ClassResource>();
            CreateMap<ClassType, ClassTypeResource>();
            CreateMap<Course, CourseResource>();
            CreateMap<Division, DivisionResource>();
            CreateMap<Enrollment, EnrollmentResource>();
            CreateMap<EnrollmentDuration, EnrollmentDurationResource>();
            CreateMap<Parent, ParentResource>();
            CreateMap<Student, StudentResource>();
            CreateMap<Subject, SubjectResource>();
        }
    }
}