using Microsoft.EntityFrameworkCore;
using OnlineEdu.Controllers;
using OnlineEdu.Data;
using System.Collections.Generic;
using System.Linq;
namespace OnlineEdu.repository
{
    public class Enrollmentrepository : IEnrollmentRepository
    {
        private CoursePortalDbContext _enrollments;

        public Enrollmentrepository(CoursePortalDbContext enrollments)
        {
            _enrollments = enrollments;
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            _enrollments.Add(enrollment);
        }

        public void DeleteEnrollment(int id)
        {
            var enrollment = GetEnrollmentById(id);
            if (enrollment != null)
            {
                _enrollments.Remove(enrollment);
            }
        }

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return _enrollments.Enrollments.ToList();
        }

        public Enrollment GetEnrollmentById(int id)
        {
            return _enrollments.Enrollments.FirstOrDefault(e => e.EnrollmentId == id);
        }

        public void UpdateEnrollment(Enrollment enrollment)
        {
            var existingEnrollment = GetEnrollmentById(enrollment.EnrollmentId);
            if (existingEnrollment != null)
            {
                existingEnrollment.StudentId = enrollment.StudentId;
                existingEnrollment.CourseId = enrollment.CourseId;
                existingEnrollment.Progress = enrollment.Progress;
            }
        }
        public void UpdateProgress(int enrollmentId, double progress)
        {
            var enrollment = _enrollments.Enrollments.Find(enrollmentId);
            if (enrollment != null)
            {
                enrollment.Progress = progress;
                _enrollments.SaveChanges();
            }
        }

    }
}