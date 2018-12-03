using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris sveikuosius skaicius");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
            Console.WriteLine("{0} - {1} - {2} = {3}", a, b, c, a - b - c);
            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, a * b * c);
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, (double)a / b / c);
        }
    }
}
