using Application_layer.Entities;
using School_System.School_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system
{
    public class AddingToDb : IAddingToDb
    {
        public Student AddStudentToDatabase() 
        {
            Console.WriteLine("Please enter new student credentials:");
            var name = Console.ReadLine();
            var lastName = Console.ReadLine();
            Student student = new Student(name,lastName);  //there should be check if student already exist in db
           return student;
        }

        public Teacher AddTeacherToDatabase()   // to implement
        {
            throw new NotImplementedException();
        }
    }
}
