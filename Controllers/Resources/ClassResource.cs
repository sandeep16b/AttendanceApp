using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Controllers.Resources
{
    public class ClassResource
    {
        public int Id { get; set; }
     
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int NoOfOccurences { get; set; }


        public string Frequency { get; set; }

        public int Holidays { get; set; }

        public ICollection<EnrollmentResource> Enrollments {get; set;}
        public ClassResource()
        {
            Enrollments = new Collection<EnrollmentResource>();
        }

   

       

    }
}