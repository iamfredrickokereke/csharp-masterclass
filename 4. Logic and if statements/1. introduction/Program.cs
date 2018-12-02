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
            int temperature;
            int number;
            bool userEnteredANumber = int.TryParse(temp, out number);

            if (userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
                Console.WriteLine("value entered, was no number. 0 is set as temperature");
            }

            if (temperature < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Pants and pullover should be fine");
            }
            else if (temperature > 30)
            {
                Console.WriteLine("It is super hot");
            }
            else 
            {
                Console.WriteLine("Shorts are enough for today");
            }

            Console.Read();
        }
    }
}
