using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public StudentController(CoursePortalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Student Student)
        {
            _context.Students.Add(Student);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Student> GetEvents()
        {
            return _context.Students.ToList();
        }
    }
}

