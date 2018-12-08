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
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        // constructor


        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}, and I am {2} years old. My eyes are {3}.", firstName, lastName, age, eyeColor);
        }
    }
}
