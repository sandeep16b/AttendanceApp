using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyApp.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
       
        public Class Class {get; set;}

        public int ClassID { get; set; }
        
     
        public Student Student {get; set;}
        public int StudentID { get; set; }

       public EnrollmentDuration EnrollmentDuration { get; set; }

        public int EnrollmentDurationId { get; set; }
        
    }
}