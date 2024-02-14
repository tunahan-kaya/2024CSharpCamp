using Day2Task3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task3.Business.Abstract;

public interface ICourseService
{
    public void Add(Course course);
    public void Update(Course course);
    public void Delete(Course course);
    public void GetAll();
}
