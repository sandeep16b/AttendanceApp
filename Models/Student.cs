using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceApp.Models
{
    public class Student
    {
         public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        [StringLength(255)]
        public string School { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        [StringLength(255)]
        public string City { get; set; }
        [Required]
        [StringLength(255)]
        public string State { get; set; }

        [Required]
        [StringLength(255)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(255)]
        public string Country { get; set; }

        public Parent Parent {get; set;}

        public int ParentId {get; set;}

        public ICollection<Enrollment> Enrollments {get; set;}
        public Student()
        {
            Enrollments = new Collection<Enrollment>();
        }

    }
}