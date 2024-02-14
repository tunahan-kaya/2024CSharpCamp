using Day2Task3.Business.Abstract;
using Day2Task3.DataAccess.Abstract;
using Day2Task3.Entities;

namespace Day2Task3.Business.Concrete;

public class InstructorManager : IInstructorService
{
    private IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
        Console.WriteLine("kurs eklendi: " + instructor.Name);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
        Console.WriteLine("Kurs silindi: " + instructor.Name);
    }

    public void GetAll()
    {
        IEnumerable<Instructor> instructoies = _instructorDal.GetAll();

        foreach (var instructor in instructoies)
        {
            Console.WriteLine(instructor.Id + " " + instructor.Name);
        }
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
        Console.WriteLine("Kurs güncellendi: " + instructor.Name);
    }
}
