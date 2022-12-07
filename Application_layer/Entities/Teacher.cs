using Application_layer.Entities.Consts;
using Application_layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_layer.Entities
{
    public sealed class Teacher : Person, ISystemUser
    {
        public int Expirience { get;private set; } 
        public Subject Subject { get; private set; }
        public List<Student> students { get;private set; } = new List<Student>();

        public Teacher()
        {

        }
        public Teacher(string name, string lastname, Subject subject) : base(name,lastname)
        {
            Subject = subject;
        }
        public override void Output()
        {
            Console.WriteLine($"Teacher: {Name} {LastName}. Subject {Subject}.");
        }
       public void ViewAllTecherStudents()
        {
            foreach(var x in students)
            {
                x.Output();
            }
        }
        
    }
}
