using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner", "blue", 34);
            Human mantas = new Human("Mantas", "Masalis", "brown", 28);
            sissy.IntroduceMyself();
            mantas.IntroduceMyself();

            Console.Read();
        }
    }
}
