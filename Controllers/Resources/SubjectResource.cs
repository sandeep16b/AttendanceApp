using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class SubjectResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CategoryResource> Categories {get; set;}
        public SubjectResource()
        {
            Categories = new Collection<CategoryResource>();
        }

    }
}