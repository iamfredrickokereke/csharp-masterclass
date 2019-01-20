using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherintanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());
            
            ImagePost imagepost1 = new ImagePost("Check out my new shoes", "Denis Panjuta", "https://images.com/shoes", true);
            Console.WriteLine(imagepost1.ToString());

            Console.ReadLine();
        }
    }
}
