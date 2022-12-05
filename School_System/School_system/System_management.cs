using Application_layer;
using Application_layer.Entities;
using School_System.School_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system
{
    public class System_management : ISystem_management
    {
        private readonly IAddingToDb _addingToDb;
        private readonly IGetPerson _getPerson;
        private readonly IViewMethods _viewMethods;
        private readonly IAddGrade _addGrade;

        public System_management(IAddingToDb addingToDb,IGetPerson getPerson, IViewMethods viewMethods, IAddGrade addGrade)
        {
            _addingToDb = addingToDb;
            _getPerson = getPerson;
            _viewMethods = viewMethods;
            _addGrade = addGrade;
        }
        public void Process()
        {
            FakeDatabase db = new FakeDatabase();
            var student = new Student();
            var teacher = new Teacher();
            int menu = 0;
            while (true)
            {
                Console.WriteLine("Please enter number: ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        student = _addingToDb.AddStudentToDatabase();
                        db.AddNewStudent(student);
                        break;
                    case 1:
                        teacher = _getPerson.GetTeacher(db.teachers);
                        _viewMethods.ShowAllStudentsAssignToTeacher(teacher);
                        break;
                    case 2:
                        teacher = _getPerson.GetTeacher(db.teachers);
                        student = _getPerson.GetStudent(db.students);
                        teacher.students.Add(student);
                        break;
                    case 3:
                        teacher = _getPerson.GetTeacher(db.teachers);
                        _addGrade.AddGradesFromExam(teacher);     //grade form exam
                        _viewMethods.ViewAllStudentsGrades(teacher);
                        break;
                    case 4:
                        teacher = _getPerson.GetTeacher(db.teachers);
                        _viewMethods.ShowAllStudentsAssignToTeacher(teacher);
                        Console.WriteLine("Select particular student to write grades in: ");
                        student = _getPerson.GetStudent(teacher.students);
                        _addGrade.AddGradesFromOralAnswer(student);     //grade from oral answer
                        _viewMethods.ViewAllStudentsGrades(teacher);
                        break;

                }
            }

        }
    }
}
