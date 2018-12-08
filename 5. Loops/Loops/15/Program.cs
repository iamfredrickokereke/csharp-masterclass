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
            string zodis = "";
            string tekstas = "";

            while (zodis!= "exit")
            {
                tekstas += zodis + " ";
                Console.WriteLine("Iveskite zodi arba exit");
                zodis = Console.ReadLine();
            }
            Console.WriteLine(tekstas);
        }
    }
}
