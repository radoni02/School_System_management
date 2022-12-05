using Application_layer.Entities;
using School_System.School_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system
{
    public class ViewMethods : IViewMethods
    {
        public void ViewAllStudentsAverage(List<Student> students)
        {
            foreach (var x in students)
            {
                x.Output();
            }
        }
        public void ViewAllStudentsGrades(Teacher teacher)
        {
            var result = teacher.students.OrderBy(x => x.LastName);
            foreach (var x in result)
            {
                x.ShowGrades();
            }
        }
        public void ShowAllStudentsAssignToTeacher(Teacher teacher)
        {
            //var teacher = GetTeacher(teachers);
            
            teacher.ViewAllTecherStudents();
        }
    }
}
