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
    public class LocationsController : Controller
    {
        private readonly AttendanceDbContext context;
        public LocationsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
        [HttpGet("/api/locations")]
        public async Task<IEnumerable<LocationResource>> GetLocations(){
            var locations = await context.Locations.ToListAsync();
            return Mapper.Map<List<Location>, List<LocationResource>>(locations);
        }
    }
}