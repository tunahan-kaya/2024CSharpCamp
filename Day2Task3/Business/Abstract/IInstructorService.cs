using Day2Task3.Entities;

namespace Day2Task3.Business.Abstract;

public interface IInstructorService
{
    public void Add(Instructor instructor);
    public void Update(Instructor instructor);
    public void Delete(Instructor instructor);
    public void GetAll();
}
