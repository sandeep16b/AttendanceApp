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
    public class SubjectsController
    {
        private readonly AttendanceDbContext context;
        
        public SubjectsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }

        [HttpGet("/api/subjects")]
        public async Task<IEnumerable<SubjectResource>> GetSubjects(){
            var subjects = await context.Subjects.Include(m => m.Categories).ToListAsync();
            return Mapper.Map<List<Subject>, List<SubjectResource>>(subjects);
        }
    }
}