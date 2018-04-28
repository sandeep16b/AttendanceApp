using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class EnrollmentDurationResource
    {
         public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EnrollmentResource> Enrollments {get; set;}
        public EnrollmentDurationResource()
        {
            Enrollments = new Collection<EnrollmentResource>();
        }
    }
}