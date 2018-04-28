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
    public class CategoriesController
    {
       
        private readonly AttendanceDbContext context;

        public CategoriesController(AttendanceDbContext context, IMapper mapper)
        {
            this.context = context;

        }
       
        [HttpGet("/api/categories")]
        public async Task<IEnumerable<CategoryResource>> GetCategories(){
            var categories = await context.Categories.Include(m => m.SubCategories).ToListAsync();
            return Mapper.Map<List<Category>, List<CategoryResource>>(categories);
        }
    }
  
}