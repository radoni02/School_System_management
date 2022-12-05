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
            
            Student student1 = new Student() { Name = "James", LastName = "Lenon", Pesel = "12312312312", Gender = Gender.male, Address = "Los Santos", Average = 0 };
            Student student2 = new Student() { Name = "Tim", LastName = "Cory", Pesel = "92837459213", Gender = Gender.male, Address = "Chicago", Average = 0};
            Student student3 = new Student() { Name = "Anna", LastName = "Covincton", Pesel = "18364018342", Gender = Gender.female, Address = "Dallas", Average = 0 };
            Student student4 = new Student() { Name = "Sara", LastName = "James", Pesel = "99999999999", Gender = Gender.female, Address = "New York", Average = 0};
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
            Teacher teacher1 =  new Teacher { Name = "Joe", LastName = "Mama", Expirience = 5, Subject = Subject.Math };
            teachers.Add(teacher1);
            systemUsers.Add(teacher1);

        }



        public /*List<ISystemUser>*/void AddNewStudent(Student student)
        {
            Student student1 = new Student() { Name = student.Name, LastName = student.LastName };
            students.Add(student1);
            systemUsers.Add(student1);
            //systemUsers.Add(new Student() { Name = student.Name, LastName = student.LastName });
            //return systemUsers;
        }
       

    }
}
