using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sveikasSkaicius = 65;
            int pirmas = sveikasSkaicius / 10;
            int antras = sveikasSkaicius % 10;

            int atsakymas = pirmas * antras;

            Console.WriteLine("{0} * {1} = {2}", pirmas, antras, atsakymas);
            Console.Read();
        }
    }
}
