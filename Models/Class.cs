using System;
using System.ComponentModel.DataAnnotations;

namespace AttendanceApp.Models
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public int NoOfOccurences { get; set; }
         [Required]
        [StringLength(255)]

        public string Frequency { get; set; }
        [Required]
        public int Holidays { get; set; }

        public Course Course {get; set;}

        public int CourseId {get; set;}

         public Location Location {get; set;}

        public int LocationId {get; set;}

         public ClassType ClassType {get; set;}

        public int ClassTypeId {get; set;}


    }
}