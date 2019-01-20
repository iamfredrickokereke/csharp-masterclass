using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Enums
{
    class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su };
        enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;
            Day a = Day.Fr;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);
            Console.WriteLine((int)Months.Feb);
            Console.WriteLine((int)Months.Aug);
            Console.ReadKey();
        }
    }
}
