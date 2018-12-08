using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            //skaiciu speliojimo zaidimas

            var rnd = new Random();
            var slaptas = rnd.Next(1, 1001);
            var spejimas = 1;

            while (spejimas != slaptas)
            {
                Console.WriteLine("Spekite skaiciu nuo 1 iki 1000");
                spejimas = Convert.ToInt32(Console.ReadLine());
                if (spejimas > slaptas)
                {
                    Console.WriteLine("Skaicius mazesnis, bandykite dar karta");
                }
                else if (spejimas < slaptas)
                {
                    Console.WriteLine("Skaicius didesnis, bandykite dar karta");
                }
                else
                {
                    Console.WriteLine("Sveikiname, jus laimejote");
                }
            }
        }
    }
}
