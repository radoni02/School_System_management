using Application_layer.Entities.Consts;
using Application_layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_layer.Entities
{
    public sealed class Student : Person, ISystemUser
    {
        public List<Grades> grades { get;private set; }
       
        public double Average { get;private set; }

        public bool IsSuperior { get;private set; }
        public Student()
        {
            grades = new List<Grades>();
            IsSuperior = false;
        }

        public Student(string name, string lastname) : base(name, lastname)
        {
            grades = new List<Grades>();
            IsSuperior = false;
        }
        public Student(string name, string lastname, double average, Gender gender, string address)
            : base(name,lastname,address,gender)
        {
            grades = new List<Grades>();
            IsSuperior = false;
            Average = average;
        }

        public override void Output()
        {
            Console.WriteLine($"Student:{Name} {LastName}, average: {Average}.");
        }
        //public override void Output()                       base. nie zadziała bo klasa to void gdyby była np string to działałoby
        //{
        //    var output = base.Output();
        //    output += ("Jakies dodatkowe informacje do nadpisania w tej klasie.");
        //    Console.WriteLine(output);
        //}
        public void ShowGrades()
        {
            foreach (var x in grades)
            {
                Console.WriteLine($"{Name} grade from {x.Description} : {x.Grade}");
            }
        }
        public void CalculateAverageFromOralAnswer(double grade)
        {
           Average =(Average + grade) / (grades.Count + 1);
        }
        public void CalculateAverageFromExam()
        {
            double sum = 0;
            int counter = 0;
            foreach (var x in grades)
            {
                counter++;
                sum = sum + x.Grade;
            }
            Average = sum/counter;
        }
        public void AddNewGrade(string description, double grade)
        {
            if (grade < 1 || grade > 6)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                grades.Add(new Grades(description, grade));
            }
        }
    }
}
