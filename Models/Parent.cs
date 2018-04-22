using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceApp.Models
{
    public class Parent
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public ICollection<Student> Students {get; set;}
        public Parent()
        {
            Students = new Collection<Student>();
        }
       
    }
}