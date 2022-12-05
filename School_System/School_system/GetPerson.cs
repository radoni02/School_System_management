using Application_layer.Entities;
using School_System.School_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system
{
    public class GetPerson : IGetPerson
    {
        public Student GetStudent(List<Student> students)
        {
            Console.WriteLine("Please enter student name and lastname: ");
            var name = Console.ReadLine();
            var lastname = Console.ReadLine();
            var student = students.Where(x => x.Name == name && x.LastName == lastname).FirstOrDefault();
            ArgumentNullException.ThrowIfNull(student);
            return student;
        }
        public Teacher GetTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("Please enter teacher name and lastname: ");
            var name = Console.ReadLine();
            var lastname = Console.ReadLine();
            var result = teachers.Where(x => x.Name == name && x.LastName == lastname).FirstOrDefault();
            ArgumentNullException.ThrowIfNull(result);
            return result;

        }
    }
}
