using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }   

         public int Level { get; set; }   


        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }

        public ICollection<Class> Classes {get; set;}
        
        public Course()
        {
            Classes = new Collection<Class>();
          
        }
    }
}