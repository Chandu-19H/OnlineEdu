using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;
using OnlineEdu.repository;

namespace OnlineEdu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssessmentsController : ControllerBase
    {
        private readonly IAssessmentrepository _repository;

        public AssessmentsController(IAssessmentrepository repository)
        {
            _repository = repository;
        }

        // GET: api/Assessments
        [HttpGet]
        public ActionResult<IEnumerable<Assessment>> GetAssessments()
        {
            return _repository.GetAll().ToList();
        }

        // GET: api/Assessments/5
        [HttpGet("{id}")]
        public ActionResult<Assessment> GetAssessment(int id)
        {
            var assessment = _repository.GetById(id);

            if (assessment == null)
            {
                return NotFound();
            }

            return assessment;
        }

        // POST: api/Assessments
        [HttpPost]
        public ActionResult<Assessment> PostAssessment(Assessment assessment)
        {
            _repository.Add(assessment);
            return CreatedAtAction(nameof(GetAssessment), new { id = assessment.AssessmentId }, assessment);
        }

        // PUT: api/Assessments/5
        [HttpPut("{id}")]
        public IActionResult PutAssessment(int id, Assessment assessment)
        {
            if (id != assessment.AssessmentId)
            {
                return BadRequest();
            }

            _repository.Update(assessment);
            return NoContent();
        }

        // DELETE: api/Assessments/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAssessment(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}