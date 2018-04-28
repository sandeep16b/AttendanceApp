using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class CourseResource
    {
         public int Id { get; set; }
  
        public string Name { get; set; }   

         public int Level { get; set; }   

        public ICollection<ClassResource> Classes {get; set;}
        
        public CourseResource()
        {
            Classes = new Collection<ClassResource>();
          
        }
    }
}