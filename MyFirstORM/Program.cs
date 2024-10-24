using MyFirstORM.Data;
using MyFirstORM.Models;
using MyFirstORM.Repasitory;

namespace MyFirstORM
{
    class DBCRUD { 
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            appDBContext app=new appDBContext();

            TeacherRepository trep = new TeacherRepository(app);
            StudentRepository srep = new StudentRepository(app);
            CourseRepository crep = new CourseRepository(app);

            Teacher teacher = trep.GetTeacherById(1);
            Student student = srep.GetStudentById(1);
            Course course = new Course() { 
               Name="Dasturlash asoslari",
               Teacher=teacher,
               Student=student,
            };

            crep.AddCourse(course);

        }
    }
}
