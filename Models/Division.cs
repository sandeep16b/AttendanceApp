using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceApp.Models
{
    public class Division
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Location> Locations {get; set;}
        public Division()
        {
            Locations = new Collection<Location>();
        }
    }

   
}