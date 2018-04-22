using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceApp.Models
{
    [Table("Locations")]
    public class Location
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        [Required]
        [StringLength(255)]

        public Division Division { get; set; }

        public int DivisionId { get; set; }

         public ICollection<Class> Classes {get; set;}
        public Location()
        {
            Classes = new Collection<Class>();
        }
    }
}