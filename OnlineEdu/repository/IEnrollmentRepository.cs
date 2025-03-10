using OnlineEdu.Data;

public interface IEnrollmentRepository
{
    public IEnumerable<Enrollment> GetAllEnrollments();
    public Enrollment GetEnrollmentById(int id);
    public void AddEnrollment(Enrollment enrollment);
    public void UpdateEnrollment(Enrollment enrollment);
    public void DeleteEnrollment(int id);
   public  void UpdateProgress(int enrollmentId, double progress);
}