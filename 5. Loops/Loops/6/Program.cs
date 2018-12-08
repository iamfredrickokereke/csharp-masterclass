using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu pradzia ir pabaiga");
            int pradzia = int.Parse(Console.ReadLine());
            int pabaiga = int.Parse(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Neteisingai ivedete");
            }

            Console.Read();
        }
    }
}
