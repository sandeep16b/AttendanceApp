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
    public class StudentsController
    {
        private readonly AttendanceDbContext context;

        public StudentsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/students")]
        public async Task<IEnumerable<StudentResource>> GetStudents(){
            var students = await context.Students.Include(m => m.Enrollments).ToListAsync();
            return Mapper.Map<List<Student>, List<StudentResource>>(students);
        }
    }
}