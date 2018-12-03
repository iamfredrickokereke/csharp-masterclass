using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu");
            int skaicius = int.Parse(Console.ReadLine());

            int kvadratas = skaicius * skaicius;
            Console.WriteLine(kvadratas);
            Console.Read();
        }
    }
}
