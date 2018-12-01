using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature");
            string temp = Console.ReadLine(); 
            int temperature = int.Parse(temp);

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }

            if (temperature == 10)
            {
                Console.WriteLine("It's 10 degree C");
            }

            if (temperature > 10)
            {
                Console.WriteLine("Cozy warm!");
            }

            Console.Read();
        }
    }
}
