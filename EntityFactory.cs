using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class EntityFactory
    {
        public abstract object Create(string[] parameters);
    }
    public class StudentFactory : EntityFactory
    {
        public override object Create(string[] parameters)
        {
            return new Student
            {
                Id = int.Parse(parameters[1]),
                Name = parameters[2],
                Courses = new List<int>()
            };
        }
    }

    public class TeacherFactory : EntityFactory
    {
        public override object Create(string[] parameters)
        {
            return new Teacher
            {
                Id = int.Parse(parameters[1]),
                Experience = int.Parse(parameters[2]),
                Name = parameters[3],
                Courses = new List<int>()
            };
        }
    }

    public class CourseFactory : EntityFactory
    {
        public override object Create(string[] parameters)
        {
            return new Course
            {
                Id = int.Parse(parameters[1]),
                Name = parameters[2],
                TeacherId = int.Parse(parameters[3]),
                Students = new List<int>()
            };
        }
    }   
}
