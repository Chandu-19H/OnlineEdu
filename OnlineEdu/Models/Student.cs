﻿namespace OnlineEdu.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string Interests { get; set; }
        public int NoOfCoursesEnrolled { get; set; }

        public User User { get; set; }

        public  ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<Submission> Submissions { get; set; }
    }
}