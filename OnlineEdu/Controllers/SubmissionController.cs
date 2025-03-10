using Microsoft.AspNetCore.Mvc;
using OnlineEdu.repository;
using OnlineEdu.Data;

namespace OnlineEdu.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionsController : ControllerBase
    {
        private readonly ISubmissionRepo _repository;

        public SubmissionsController(ISubmissionRepo repository)
        {
            _repository = repository;
        }

        [HttpGet("Getallsubmission")]
        public ActionResult<IEnumerable<Submission>> GetAllSubmissions()
        {
            var submissions = _repository.GetAllSubmissions();
            return Ok(submissions);
        }

        [HttpGet("{id}")]
        public ActionResult<Submission> GetSubmissionById(int id)
        {
            var submission = _repository.GetSubmissionById(id);
            if (submission == null)
            {
                return NotFound();
            }
            return Ok(submission);
        }

        [HttpPost]
        public ActionResult<Submission> PostSubmission([FromBody] Submission submission)
        {
            _repository.AddSubmission(submission);
            return CreatedAtAction(nameof(GetSubmissionById), new { id = submission.SubmissionId }, submission);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateSubmission(int id, [FromBody] Submission submission)
        {
            if (id != submission.SubmissionId)
            {
                return BadRequest();
            }
            _repository.UpdateSubmission(submission);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSubmission(int id)
        {
            _repository.DeleteSubmission(id);
            return NoContent();
        }
    }
}