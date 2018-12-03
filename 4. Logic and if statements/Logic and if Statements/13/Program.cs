using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double atsakymas = (a + b + c) / 3;

            Console.WriteLine("skaiciu " + a + " " + b + " " + c + " vidurkis: " + atsakymas);
        }
    }
}
