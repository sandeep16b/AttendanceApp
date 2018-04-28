using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class LocationResource
    {
         public int Id { get; set; }
      
        public string Name { get; set; }
        public string City { get; set; }

        public string Type { get; set; }
 

     
         public ICollection<ClassResource> Classes {get; set;}
        public LocationResource()
        {
            Classes = new Collection<ClassResource>();
        }
    }
}