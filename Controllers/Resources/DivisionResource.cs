using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class DivisionResource
    {
         public int Id { get; set; }
       
        public string Name { get; set; }

        public ICollection<LocationResource> Locations {get; set;}
        public DivisionResource()
        {
            Locations = new Collection<LocationResource>();
        }
    }
}