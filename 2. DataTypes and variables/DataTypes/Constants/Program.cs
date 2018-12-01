using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    // Constants are imutable values which are known
    // At copile time and do not change for the life of the program

    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "1990.02.10";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}",  birthday);
            Console.ReadKey();
        }
    }
}
