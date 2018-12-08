using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasirinkimas = "t";
           
            while (pasirinkimas == "t")
            {
                Console.WriteLine("Iveskite du skacius");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
                Console.WriteLine("Ar norite testi darba? t/n");
                pasirinkimas = Console.ReadLine();
            }
            Console.WriteLine("Programos pabaiga");
            Console.Read();
        }
    }
}
