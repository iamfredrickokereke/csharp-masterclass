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
            Console.WriteLine("Iveskite reziu pradzia ir pabaiga");
            int pradzia = int.Parse(Console.ReadLine());
            int pabaiga = int.Parse(Console.ReadLine());

            if(pradzia < pabaiga)
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {
                    Console.WriteLine("{0} - {1}", i, i*i);
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
