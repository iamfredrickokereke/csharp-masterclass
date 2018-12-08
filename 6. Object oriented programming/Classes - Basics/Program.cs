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
            Human sissy = new Human();
            sissy.firstName = "Sissy";
            sissy.lastName = "Wagner";
            sissy.IntroduceMyself();

            Human franzl = new Human();
            franzl.firstName = "Franzl";
            franzl.lastName = "Muller";
            franzl.IntroduceMyself();

            Console.Read();
        }
    }
}
