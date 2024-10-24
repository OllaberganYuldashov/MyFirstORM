using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstORM.Models;

namespace MyFirstORM.Data
{
    internal class appDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstring = "Server=(localdb)\\MSSQLLocalDB; Database=UniversityDB; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connstring);
        }
    }
}
