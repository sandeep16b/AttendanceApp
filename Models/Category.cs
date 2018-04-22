using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceApp.Models
{
    public class Category
    {
         public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories {get; set;}
        public Category()
        {
            SubCategories = new Collection<SubCategory>();
        }
        public Subject Subject { get; set; }

        public int SubjectId { get; set; }

    }
}