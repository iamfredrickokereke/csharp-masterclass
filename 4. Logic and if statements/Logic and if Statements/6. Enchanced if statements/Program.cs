using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Enchanced_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expresion : second_expresion;
            // condition has to be either true or false
            // the conditional operator is right = associative.
            // the expression a ? b: c? d : e
            // is evaluated as a ? b : (c ? d: e),
            // not as (a ? b : c) ? d : e.
            // The conditional operator cannot be overloaded.

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "Solid";
            else if (temperature > 100)
                stateOfMatter = "Gas";
            else
                stateOfMatter = "Liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            // in short

            stateOfMatter = temperature < 0 ? "Solid" : "Liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            // challenge - add the gas state of matter to the options
            temperature += 100;

            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Liguid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.Read();

        }
    }
}
