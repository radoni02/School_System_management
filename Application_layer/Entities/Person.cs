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
        public string Name { get;private set; }
        public string LastName { get;private set; }
        
        //[StringLength(11,ErrorMessage = "Pesel should contain 11 numbers.") ]
        public string Pesel { get; init; }
        public string Address { get;private set; }
        public Gender Gender { get; init; }
        protected Person()
        {

        }

        protected Person(string name,string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        protected Person(string name, string lastName, string address, Gender gender)
            : this(name, lastName)
        {
            Address = address;
            Gender = gender;
        }

        public abstract void Output();  //jeżeli nie chce deklarowac zadnego defaultowego przypadku
        //public virtual void Output()
        //{
        //    Console.WriteLine("Błąd w łądowaniu bazy danych.");  // jeżeli chce dodac przypadek bazowy
        //}

    }
}
