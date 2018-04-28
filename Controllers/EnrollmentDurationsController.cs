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
    public class EnrollmentDurationsController
    {
        
        private readonly AttendanceDbContext context;

        public EnrollmentDurationsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/enrollmentdurations")]
        public async Task<IEnumerable<EnrollmentDurationResource>> GetEnrollmentDurations(){
            var enrollmentDurations = await context.EnrollmentDurations.Include(m => m.Enrollment).ToListAsync();
            return Mapper.Map<List<EnrollmentDuration>, List<EnrollmentDurationResource>>(enrollmentDurations);
        }

    }
   
}