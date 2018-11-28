using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Mantas";
            string message = "My name is " + myName;
            string capsMessage = message.ToUpper();

            string greet = "Hello " + myName;
            string lGreet = greet.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lGreet);
            Console.Read();
        }
    }
}
