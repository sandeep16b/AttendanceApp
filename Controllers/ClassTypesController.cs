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
    public class ClassTypesController
    {
       
        private readonly AttendanceDbContext context;

        public ClassTypesController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/classtypes")]
        public async Task<IEnumerable<ClassTypeResource>> GetClassTypesController(){
            var classTypes = await context.ClassTypes.Include(m => m.Classes).ToListAsync();
            return Mapper.Map<List<ClassType>, List<ClassTypeResource>>(classTypes);
        }
    
    }
  
}