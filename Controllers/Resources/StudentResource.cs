using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class StudentResource
    {
        public int Id { get; set; }
     
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }


        public string ZipCode { get; set; }

 
        public string Country { get; set; }

    

        public ICollection<EnrollmentResource> Enrollments {get; set;}
        public StudentResource()
        {
            Enrollments = new Collection<EnrollmentResource>();
        }

    }
}