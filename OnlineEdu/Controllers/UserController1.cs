using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController1 : ControllerBase
    {
        private readonly CoursePortalDbContext _context;
        public UserController1(CoursePortalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<User> GetEvents()
        {
            return _context.Users.ToList();
        }
    }
}
