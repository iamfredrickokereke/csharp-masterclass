using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Chalenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Mantas";
            string friend2 = "Darius";
            string friend3 = "Petras";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hello " + friendName + ", my Friend");
        }

    }
}
