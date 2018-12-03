using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki simboli");
            string symbol = Console.ReadLine();

            Console.WriteLine("{0}{0}{0}", symbol);
            Console.WriteLine("{0}{0}{0}", symbol);
            Console.WriteLine("{0}{0}{0}", symbol);
            Console.Read();
        }
    }
}
