﻿using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.Data
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        public int InstructorId { get; set; }
        public virtual Instructor? Instructor { get; set; }
        [Required]
        public string ContentURL {  get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
        
        
    }
}
