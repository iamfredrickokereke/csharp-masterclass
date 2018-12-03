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
            Console.WriteLine("Iveskite tris sveikuosius");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("{0} = {1}", a, b);
            }

            if (b == c)
            {
                Console.WriteLine("{0} = {1}", b, c);
            }

            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }

            if (b > c * 2)
            {
                Console.WriteLine("{0} > {1}", b, c * 2);
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} lyginis", a);
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("{0} nelyginis", b);
            }

            if (c > 0)
            {
                Console.WriteLine(c + " teigiamas skacius");
            }

            if (c < 0)
            {
                Console.WriteLine(c + " neigimas skacius");
            }

            Console.Read();
        }
    }

}
