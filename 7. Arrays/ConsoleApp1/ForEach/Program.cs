using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
            }

            //Create an array with 5 names
            //create foreach loop which greets all of them

            string[] names = new string[] { "Mantas", "Darius", "Dzeina", "Saulius", "Ignas" };

            foreach (string name in names)
            {
                Console.WriteLine("Hello {0}", name);
            }

            Console.ReadKey();
        }
    }
}
