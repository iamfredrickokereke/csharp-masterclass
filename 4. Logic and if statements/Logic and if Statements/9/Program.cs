using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu vardas {0}, o amzius: {1}", vardas, amzius);
            Console.Read();
                
        }
    }
}
