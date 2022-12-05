using Application_layer.Entities;
using School_System.School_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system
{
    public class AddGrade : IAddGrade
    {
        public void AddGradesFromOralAnswer(Student student)
        {   
            double grade = Convert.ToDouble(Console.ReadLine());
            student.Average = (student.Average + grade) / (student.grades.Count + 1);
            student.grades.Add(new Application_layer.Entities.Consts.Grades("Oral Answer:", grade));
        }
        public void AddGradesFromExam(Teacher teacher)
        {
            double grade;
            foreach (var x in teacher.students)
            {
                grade = Convert.ToDouble(Console.ReadLine());
                x.grades.Add(new Application_layer.Entities.Consts.Grades("Exam", grade));
                x.CalculateAverage();
            }
        }
    }
}
