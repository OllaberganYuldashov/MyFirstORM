﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstORM.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
