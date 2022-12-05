using School_System.School_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.School_system
{
    public static class Factory
    {
        public static ISystem_management System_Management()
        {
            return new System_management(new AddingToDb(), new GetPerson(), new ViewMethods(), new AddGrade());
        }
    }
}
