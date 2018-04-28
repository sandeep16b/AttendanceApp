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
    public class ClassesController
    {
       
        private readonly AttendanceDbContext context;

        public ClassesController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/classes")]
        public async Task<IEnumerable<ClassResource>> GetClasses(){
            var classes = await context.Classes.Include(m => m.Enrollments).ToListAsync();
            return Mapper.Map<List<Class>, List<ClassResource>>(classes);
        }
    
    }
   
}