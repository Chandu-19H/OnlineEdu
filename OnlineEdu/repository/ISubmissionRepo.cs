using OnlineEdu.Data;

namespace OnlineEdu.repository
{
    public interface ISubmissionRepo
    {
        public IEnumerable<Submission> GetAllSubmissions();
        public Submission GetSubmissionById(int id);
        public void AddSubmission(Submission submission);
        public void UpdateSubmission(Submission submission);
        public void DeleteSubmission(int id);
    }
}
