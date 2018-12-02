using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("to young to party in a club");
                    break;
                case 25:
                    Console.WriteLine("Good to go");
                    break;
                default:
                    Console.WriteLine("How old are you then");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("to young to party in a club");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go");
            }
            else
            {
                Console.WriteLine("How old are you then");
            }

            string username = "Mantas";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Username is Denis");
                    break;
                case "root":
                    Console.WriteLine("Username is root");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;

            }


            Console.Read();

        }
    }
}
