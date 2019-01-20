using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.How_To_Read_From_A_TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Example 1 - reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\textFile.txt");

            Console.WriteLine("textFile contains following text: {0}", text);

            // Example 2
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\textFile.txt");

            Console.WriteLine("Contents of textfile.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */

            // Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\highscores.txt", lines);

            // Method 2
            Console.WriteLine("please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter text for the file");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\" + fileName + ".txt", input);

            // Method 3

            using (StreamWriter file = new StreamWriter(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\mytext.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\manta\Documents\csharp-masterclass\9. Polymorphism\mytext3.txt", true))
            {
                file.WriteLine("Additional line");
            }

            Console.ReadKey();
        }
    }
}
