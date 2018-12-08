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
            Console.WriteLine("Iveskite neigiama skaiciu");
            int skaicius = int.Parse(Console.ReadLine());

            while (skaicius <= 0)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
            Console.Read();
        }
    }
}
