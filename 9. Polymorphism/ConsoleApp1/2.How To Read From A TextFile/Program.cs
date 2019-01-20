using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.How_To_Read_From_A_TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\textFile.txt");

            Console.WriteLine("textFile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\textFile.txt");

            Console.WriteLine("Contents of textfile.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.ReadKey();
        }
    }
}
