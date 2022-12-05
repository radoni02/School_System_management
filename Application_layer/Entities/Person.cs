using Application_layer.Entities.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_layer.Entities
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        
        //[StringLength(11,ErrorMessage = "Pesel should contain 11 numbers.") ]
        public string Pesel { get; init; }
        public string Address { get; set; }
        public Gender Gender { get; init; }

        public abstract void Output();  //jeżeli nie chce deklarowac zadnego defaultowego przypadku
        //public virtual void Output()
        //{
        //    Console.WriteLine("Błąd w łądowaniu bazy danych.");  // jeżeli chce dodac przypadek bazowy
        //}

    }
}
