namespace AttendanceApp.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
       
        public Class Class {get; set;}

        public int ClassID { get; set; }
        
     
        public Student Student {get; set;}
        public int StudentID { get; set; }
        
    }
}