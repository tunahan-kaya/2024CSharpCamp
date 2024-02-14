using Day2Task3.Core.DataAccess.EntityFramework;
using Day2Task3.DataAccess.Abstract;
using Day2Task3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task3.DataAccess.Concrete.EntityFramework;

public class EfCourseDal : EfRepositoryBase<Course,BaseDbContext>,ICourseDal
{

}
