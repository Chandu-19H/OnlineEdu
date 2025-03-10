using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController1: ControllerBase
    {
        private readonly CoursePortalDbContext _context;

        public UserController1(CoursePortalDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = user.UserID }, user);
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
    }
}