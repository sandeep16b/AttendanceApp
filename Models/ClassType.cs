using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class ClassType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Class> Classes {get; set;}
        public ClassType()
        {
            Classes = new Collection<Class>();
        }


    }
}