using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class SubCategoryResource
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CourseResource> Courses {get; set;}
        public SubCategoryResource()
        {
            Courses = new Collection<CourseResource>();
        }
      
    }
}