using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite bet koki skaiciu");
            int skaicius = int.Parse(Console.ReadLine());

            while (skaicius % 9 != 0)
            {
                Console.WriteLine("Iveskite bet koki skaiciu");
                skaicius = int.Parse(Console.ReadLine());

                if (skaicius % 9 == 0)
                {
                    Console.WriteLine("Ivedete skaiciu kuris dalinasi is devyniu");
                }
            }
            Console.Read();
        }
    }
}
