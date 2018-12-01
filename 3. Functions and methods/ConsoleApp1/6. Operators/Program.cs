using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num); // 1
            Console.WriteLine("num is {0}", num++); // 1
            // pree increment
            Console.WriteLine("num is {0}", ++num); // 3

            // decrement operators
            num--;
            Console.WriteLine("num is {0}", num); // 1
            Console.WriteLine("num is {0}", num--); // 1
            // pree decrement
            Console.WriteLine("num is {0}", --num); // 3

            int result;

            result = num1 + num2;
            Console.WriteLine("result is num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result is num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result is num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result is num1 / num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result is num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 > num2;

            Console.WriteLine("result is num1 > num2 is {0}", isLower);

            // equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine("result is num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result is num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;

            // condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower and is Sunny is {0}", isLowerAndSunny);

            // condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower or is Sunny is {0}", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
