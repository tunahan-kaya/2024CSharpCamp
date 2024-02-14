using Day2Task3.Business.Abstract;
using Day2Task3.DataAccess.Abstract;
using Day2Task3.DataAccess.Concrete.EntityFramework;
using Day2Task3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task3.Business.Concrete;
public class CourseManager : ICourseService
{
    private ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
        Console.WriteLine("kurs eklendi: "+course.Name);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
        Console.WriteLine("Kurs silindi: "+ course.Name);
    }

    public void GetAll()
    {
       IEnumerable<Course> courses = _courseDal.GetAll();

       foreach (var course in courses)
        {
            Console.WriteLine(course.Id +" "+ course.Name);
        }
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
        Console.WriteLine("Kurs güncellendi: "+course.Name);
    }
}
