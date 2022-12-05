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
            Student newStudent = new Student();
            newStudent.Name = Console.ReadLine();
            newStudent.LastName = Console.ReadLine();
            return newStudent;
            //CheckIfStudentExistInDb(newStudent.Name, newStudent.LastName,students);
        }

        public Teacher AddTeacherToDatabase()   // do zaimplementowania
        {
            throw new NotImplementedException();
        }
    }
}
