using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepykla
{
    class Program
    {
        static void Main(string[] args)
        {
            int valandos = 8;
            Console.WriteLine("Kiek darbuotojas iskepa kepalu per valanda?");
            int kepaluPerValanda = int.Parse(Console.ReadLine());
            Console.WriteLine("Kiek darbuotoju dirba kepykloje");
            int darbuotojai = int.Parse(Console.ReadLine());
            Console.WriteLine("Kokia yra vieno kepalo savikaina?");
            double savikaina = double.Parse(Console.ReadLine());
            Console.WriteLine("Kokia yra vieno kepalo pardavimo kaina?");
            double pardavimoKaina = double.Parse(Console.ReadLine());
            Console.WriteLine("Kiek kepykla turi uzsakymu per diena?");
            int uzsakymai = int.Parse(Console.ReadLine());

            int visoKepalu = valandos * darbuotojai * kepaluPerValanda;
            double visuSavikaina = visoKepalu * savikaina;
            double pajamos = visoKepalu * pardavimoKaina;
            double pelnas = pajamos - visuSavikaina;
            int arSpesIskepti = visoKepalu - uzsakymai;

            Console.WriteLine("Kepykla per viena darbo diena iskepa " + visoKepalu + " kepalu");
            Console.WriteLine("Visu kepalu savikaina yra {0}", visuSavikaina);
            Console.WriteLine("Visu kepalu pajamos yra {0}", pajamos);
            Console.WriteLine("Visu kepalu pelnas yra {0}", pelnas);

            if (arSpesIskepti >= 0)
            {
                Console.WriteLine("Kepykla spes atlikti uzsakyma");
            }
            else
            {
                Console.WriteLine("Kepykla nespes atlikti uzsakymo. Jiems pritruks {0} kepalu", arSpesIskepti * -1);
            }

            Console.Read();
        }
    }
}
