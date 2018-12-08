using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiple_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner", "blue", 34);
            Human amalia = new Human("Amalia", "Panjuta", "brown");
            sissy.IntroduceMyself();
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walters", 25);
            frank.IntroduceMyself();

            Console.Read();
        }
    }
}
