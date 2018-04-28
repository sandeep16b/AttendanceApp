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
    public class SubCategoriesController
    {
       
       
        private readonly AttendanceDbContext context;

        public SubCategoriesController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/subcategories")]
        public async Task<IEnumerable<SubCategoryResource>> GetSubCategories(){
            var subcategories = await context.SubCategories.Include(m => m.Courses).ToListAsync();
            return Mapper.Map<List<SubCategory>, List<SubCategoryResource>>(subcategories);
        }
    }
    
}