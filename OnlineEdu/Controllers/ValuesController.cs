using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Models;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public ValuesController(CoursePortalDbContext _context)
        {
            this._context = _context;

        }
        [HttpGet]
        public List<Course> GetCourses() 
        {
            return _context.Courses.ToList();
        }
        [HttpPost]
        public void PostCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }
}
