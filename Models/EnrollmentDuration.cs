using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    [Table("EnrollmentDurations")]
    public class EnrollmentDuration
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

       

         public ICollection<Enrollment> Enrollment {get; set;}
        public EnrollmentDuration()
        {
            Enrollment = new Collection<Enrollment>();
        }
    }
}