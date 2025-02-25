using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.Data
{
    public class Enrollment
    {
        [Key]
        
        public int EnrollmentId { get; set; }
        [Required]
        public int StudentId { get; set; }
       
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int Progress {  get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
