using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public InstructorController(CoursePortalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Instructor Instructor)
        {
            _context.Instructors.Add(Instructor);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Instructor> GetEvents()
        {
            return _context.Instructors.ToList();
        }
    }
}

