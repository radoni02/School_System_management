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
        public string Description { get; init; }
        
        //[Range(1,6,ErrorMessage ="Grade have to be between 1 to 6.")]
        public double Grade { get; set; }

        public Grades(string description,double grade)
        {
            Description = description;
            Grade = grade;
        }
    }
}
