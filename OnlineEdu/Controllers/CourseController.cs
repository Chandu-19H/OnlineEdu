using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public CourseController(CoursePortalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Course Course)
        {
            _context.Courses.Add(Course);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Course> GetEvents()
        {
            return _context.Courses.ToList();
        }
    }
}
