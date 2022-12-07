using Application_layer.Entities;
using Application_layer.Entities.Consts;
using Application_layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_layer
{
    public class FakeDatabase
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student>();
        public List<ISystemUser> systemUsers = new List<ISystemUser>();
        public  FakeDatabase()
        {
            FillListWithDefaultTeachers();
            FillListWithDefaultStudents();
        }
        public void FillListWithDefaultStudents()
        {
            Student student1 = new Student("James","Lenon",0,Gender.Male,"Los Santos");
            Student student2 = new Student("Tim", "Cory", 0,Gender.Male, "Chicago");
            Student student3 = new Student("Anna", "Covincton", 0,Gender.Female, "Dallas");
            Student student4 = new Student("Sara", "James", 0,Gender.Female, "New York");
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            systemUsers.Add(student1);   
            systemUsers.Add(student2);   
            systemUsers.Add(student3);   
            systemUsers.Add(student4);   

        }
        public void FillListWithDefaultTeachers()
        {
            Teacher teacher1 = new Teacher("Joe", "Mama", Subject.Math);
            teachers.Add(teacher1);
            systemUsers.Add(teacher1);

        }



        public void AddNewStudent(Student student)
        {
            Student student1 = new Student(student.Name, student.LastName); 
            students.Add(student1);
            systemUsers.Add(student1);
        }
       

    }
}
