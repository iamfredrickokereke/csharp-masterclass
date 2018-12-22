using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Declaring_and_initializing_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 10;
            grades[3] = 14;
            grades[4] = 3;

            Console.WriteLine("grades at index 0 : {0} ", grades[0]);

            string input = Console.ReadLine();

            // assign value
            grades[0] = int.Parse(input);

            Console.WriteLine("grades at index 0 : {0} ", grades[0]);
            

            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathStudentsB = new int[] { 14, 13, 20, 7, 4 };

            Console.WriteLine("Lenght of A students {0}", gradesOfMathStudentsA.Length);
            Console.Read();
        }
    }
}
