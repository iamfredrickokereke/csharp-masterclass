using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
        }
    }
}
