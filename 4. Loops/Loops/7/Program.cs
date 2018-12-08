using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            // be daugybos veiksmo sudauginti du skacius
            Console.WriteLine("iveskite du skaicius");
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i < b; i++)
            {  
                a += b; 
            }
            Console.WriteLine(a);
            Console.Read();
        }
    }
}
