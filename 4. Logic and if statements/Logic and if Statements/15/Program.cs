using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a > b && a> c)
            {
                Console.WriteLine(a + " didziausias");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + " yra didziausias");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c + " yra didziausias");
            }
            else
            {
                Console.WriteLine("Skaiciai lygus");
            }

            Console.Read();
        }
    }
}
