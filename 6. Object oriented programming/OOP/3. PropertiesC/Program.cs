using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PropertiesC
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5,4,10);
            Console.WriteLine("volume is {0}", box.Volume);
           
            box.DisplayInfo();
            Console.Read();
        }
    }
}
