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
    public class EnrollmentsController
    {
        private readonly AttendanceDbContext context;

        public EnrollmentsController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/enrollments")]
        public async Task<IEnumerable<EnrollmentResource>> GetEnrollments(){
            var enrollments = await context.Enrollments.ToListAsync();
            return Mapper.Map<List<Enrollment>, List<EnrollmentResource>>(enrollments);
        }
    }
}