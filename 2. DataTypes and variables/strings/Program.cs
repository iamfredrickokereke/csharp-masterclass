using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    // class names like ClientActivity
    class Program
    {
        // Method Name like CalculateValue
        // Method arguments like firstNumber
        static void Main(string[] args)
        {
            // local variables like itemCount
            // use userControl instead of usrCtrl 

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
