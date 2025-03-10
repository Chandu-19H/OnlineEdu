using System.Collections.Generic;
using System.Linq;
using OnlineEdu.Data;


namespace OnlineEdu.repository
{
    public class SubmissionRepo : ISubmissionRepo
    {
        private readonly CoursePortalDbContext _context;

        public SubmissionRepo(CoursePortalDbContext context)
        {
            _context = context;
        }
        public void AddSubmission(Submission submission)
        {
            _context.Add(submission);
            _context.SaveChanges();
        }

        public void DeleteSubmission(int id)
        {
            var submission = _context.Submissions.Find(id);
            if (submission != null)
            {
                _context.Remove(submission);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Submission> GetAllSubmissions()
        {
            return _context.Submissions.ToList();
        }

        public Submission GetSubmissionById(int id)
        {
            return _context.Submissions.FirstOrDefault(e => e.SubmissionId == id);
        }

        public void UpdateSubmission(Submission submission)
        {
            _context.Submissions.Update(submission);
            _context.SaveChanges();
        }
    }
}
