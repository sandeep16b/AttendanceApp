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
    public class DivisionsController : Controller
    {
        private readonly AttendanceDbContext context;

        public DivisionsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }

        [HttpGet("/api/divisions")]
        public async Task<IEnumerable<DivisionResource>> GetDivisions()
        {
            var divisions = await context.Divisions.Include(m => m.Locations).ToListAsync();

            return Mapper.Map<List<Division>, List<DivisionResource>>(divisions);
        }
    }
}