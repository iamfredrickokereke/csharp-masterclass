using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            */
            int counter = 0;
            string enteredText = "";

            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by 1 and anything else + enter if you want to finish counting");
                counter++;
                enteredText = Console.ReadLine();
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} are inside the bus.", counter);

            Console.Read();
        }
    }
}
