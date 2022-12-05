using Application_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system.Interfaces
{
    public interface IGetPerson
    {
        Student GetStudent(List<Student> students);
        Teacher GetTeacher(List<Teacher> teachers);
    }
}
