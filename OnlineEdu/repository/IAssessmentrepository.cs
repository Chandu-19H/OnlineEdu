using OnlineEdu.Data;

namespace OnlineEdu.repository
{
    public interface IAssessmentrepository
    {
       
            IEnumerable<Assessment> GetAll();
            Assessment GetById(int id);
            void Add(Assessment assessment);
            void Update(Assessment assessment);
            void Delete(int id);
    }
}
