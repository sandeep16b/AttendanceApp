using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class ClassTypeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ClassResource> Classes {get; set;}
        public ClassTypeResource()
        {
            Classes = new Collection<ClassResource>();
        }

    }
}