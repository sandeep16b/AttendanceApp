using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class ParentResource
    {
          public int Id { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public ICollection<StudentResource> Students {get; set;}
        public ParentResource()
        {
            Students = new Collection<StudentResource>();
        }
    }
}