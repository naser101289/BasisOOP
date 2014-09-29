using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationApp
{
    class Student
    {
        public string id;
        public string firstName;
        public string lastName;

        public string GetFullNmae()
        {
            return firstName + " " +  lastName;
        }

    }
}
