using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Models;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserValuesController : ControllerBase
    {
        private CoursePortalDbContext _context;
        public UserValuesController(CoursePortalDbContext _context)
        {
            this._context = _context;

        }
        [HttpGet]
        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }
        [HttpPost]
        public void PostCourse(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }
    }
}
