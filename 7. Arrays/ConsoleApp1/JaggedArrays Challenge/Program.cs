using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Jagged array, which contains 3 "friends arrays", in which two family members should be storred
            //Introduce family members form different families to each other via console

            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Sandy"},
                new string[]{"Frank", "Claudia"},
                new string[]{"Andrew", "Michel"}
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}
