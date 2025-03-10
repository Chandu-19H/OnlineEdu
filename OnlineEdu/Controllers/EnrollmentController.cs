using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
    private CoursePortalDbContext _context;
    public EnrollmentController(CoursePortalDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    public void Create([FromBody] Enrollment Enrollment)
    {
        _context.Enrollments.Add(Enrollment);
        _context.SaveChanges();
    }
    [HttpGet]
    public List<Enrollment> GetEvents()
    {
        return _context.Enrollments.ToList();
    }
}
}
