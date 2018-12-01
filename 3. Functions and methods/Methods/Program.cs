using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSPecific("I am an argument and am called from the method");
            
        }

        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
   
        }

        public static void WriteSomethingSPecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
