using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required]
        public DateTime EnrolledDateTime { get; set; }
       
        public Class Class {get; set;}

        public int ClassId { get; set; }
        
     
        public Student Student {get; set;}
        public int StudentId { get; set; }

       public EnrollmentDuration EnrollmentDuration { get; set; }

        public int EnrollmentDurationId { get; set; }

        [Required]
        public string Payment { get; set; }
        
    }
}