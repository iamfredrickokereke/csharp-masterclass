using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intFloatDOuble
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 45;
            int num3, num4, num5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.54;
            double sumD = d1 / d2;

            float f1 = 3.5F;
            // Use casting
            //int divDandI = d1 / num2;

            num3 = 15;
            
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " divided by " + d2 + " is " + sumD);
            Console.Read();
        }
    }
}
