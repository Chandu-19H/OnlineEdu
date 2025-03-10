using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public  ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<Submission> Submissions { get; set; }
    }
}