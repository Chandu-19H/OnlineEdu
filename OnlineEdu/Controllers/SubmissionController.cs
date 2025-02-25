using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public SubmissionController(CoursePortalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Submission Submission)
        {
            _context.Submissions.Add(Submission);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Submission> GetEvents()
        {
            return _context.Submissions.ToList();
        }
    }
}

