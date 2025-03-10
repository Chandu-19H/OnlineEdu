using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public AssessmentController(CoursePortalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Assessment Assessment)
        {
            _context.Assessments.Add(Assessment);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Assessment> GetEvents()
        {
            return _context.Assessments.ToList();
        }
    }
}

