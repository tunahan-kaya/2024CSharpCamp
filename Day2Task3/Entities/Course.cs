﻿using Day2Task3.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task3.Entities;

public class Course : IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; }
}