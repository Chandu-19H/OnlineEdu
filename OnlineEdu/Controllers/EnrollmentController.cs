using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using OnlineEdu.Data;
using OnlineEdu.repository;
using System.Collections.Generic;

namespace OnlineEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        // GET: api/enrollment
        [HttpGet]
        public ActionResult<IEnumerable<Enrollment>> GetEnrollments()
        {
            var enrollments = _enrollmentRepository.GetAllEnrollments();
            return Ok(enrollments);
        }

        // GET: api/enrollment/{id}
        [HttpGet("{id}")]
        public ActionResult<Enrollment> GetEnrollment(int id)
        {
            var enrollment = _enrollmentRepository.GetEnrollmentById(id);
            if (enrollment == null)
            {
                return NotFound();
            }
            return Ok(enrollment);
        }

        // POST: api/enrollment
        [HttpPost]
        public ActionResult<Enrollment> PostEnrollment([FromBody] Enrollment enrollment)
        {
            _enrollmentRepository.AddEnrollment(enrollment);
            return CreatedAtAction(nameof(GetEnrollment), new { id = enrollment.EnrollmentId }, enrollment);
        }

        // PUT: api/enrollment/{id}
        [HttpPut("{id}")]
        public ActionResult PutEnrollment(int id, [FromBody] Enrollment updatedEnrollment)
        {
            var enrollment = _enrollmentRepository.GetEnrollmentById(id);
            if (enrollment == null)
            {
                return NotFound();
            }
            _enrollmentRepository.UpdateEnrollment(updatedEnrollment);
            return NoContent();
        }

        // DELETE: api/enrollment/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteEnrollment(int id)
        {
            var enrollment = _enrollmentRepository.GetEnrollmentById(id);
            if (enrollment == null)
            {
                return NotFound();
            }
            _enrollmentRepository.DeleteEnrollment(id);
            return NoContent();
        }
        [HttpPut("{id}/progress")]
        public IActionResult UpdateProgress(int id, [FromBody] double progress)
        {
            _enrollmentRepository.UpdateProgress(id, progress);
            return NoContent();
        }
    }
}