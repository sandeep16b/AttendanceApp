using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Controllers.Resources;
using MyApp.Models;
using MyApp.Persistence;

namespace MyApp.Controllers
{
    public class CoursesController
    {
        private readonly AttendanceDbContext context;

        public CoursesController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/courses")]
        public async Task<IEnumerable<CourseResource>> GetCourses(){
            var courses = await context.Courses.Include(m => m.Classes).ToListAsync();
            return Mapper.Map<List<Course>, List<CourseResource>>(courses);
        }
    
    }
}