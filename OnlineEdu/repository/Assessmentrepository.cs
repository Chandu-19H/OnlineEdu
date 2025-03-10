using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;

namespace OnlineEdu.repository
{
    public class Assessmentrepository : IAssessmentrepository
    {
        private readonly CoursePortalDbContext _context;

        public Assessmentrepository(CoursePortalDbContext context)
        {
            _context = context;
        }
       
        public void Add(Assessment assessment)
        {
         _context.Assessments.Add(assessment);
        _context.SaveChanges();  
        }

        public void Delete(int id)
        {
            var assessment = _context.Assessments.Find(id);
            if (assessment != null)
            {
                _context.Assessments.Remove(assessment);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Assessment> GetAll()
        {
            return _context.Assessments.ToList();
        }

        public Assessment GetById(int id)
        {
            return _context.Assessments.Find(id);
        }

        public void Update(Assessment assessment)
        {
            _context.Entry(assessment).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
