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
    public class ParentsController
    {
       
        private readonly AttendanceDbContext context;

        public ParentsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/parents")]
        public async Task<IEnumerable<ParentResource>> GetParents(){
            var parents = await context.Parents.Include(m => m.Students).ToListAsync();
            return Mapper.Map<List<Parent>, List<ParentResource>>(parents);
        }

    }
}