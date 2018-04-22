using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceApp.Models
{
    public class SubCategory
    {
         public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Course> Courses {get; set;}
        public SubCategory()
        {
            Courses = new Collection<Course>();
        }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}