﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstORM.Models
{
    public abstract class Person
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
