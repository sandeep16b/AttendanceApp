using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SubCategoryResource> SubCategories {get; set;}
        public CategoryResource()
        {
            SubCategories = new Collection<SubCategoryResource>();
        }
       
    }
}