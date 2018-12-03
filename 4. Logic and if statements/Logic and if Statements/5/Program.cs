using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 56;
            Console.WriteLine(Sum(a, b));
            Console.WriteLine(Minus(a, b));
            Console.WriteLine(Divide(a, b));
            Console.WriteLine(Daugint(a, b));
            Console.Read();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Daugint(double a, double b)
        {
            return a * b;
        }
    }
}



