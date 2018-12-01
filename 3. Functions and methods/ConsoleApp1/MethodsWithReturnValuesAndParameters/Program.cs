using System;

namespace MethodsWithReturnValuesAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            // int result = Add(15, 31);
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(45, 8));
            Console.WriteLine(Divide(45, 21));
            Console.Read();

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

