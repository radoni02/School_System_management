using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_layer.Entities.Consts
{
    public class Grades
    {
        public string Description { get; private set; }
        
        public double Grade { get; private set; }

        public Grades(string description,double grade)
        {
            Description = description;
            //[Range(1,6,ErrorMessage ="Grade have to be between 1 to 6.")]
            Grade = grade;
        }
    }
}
