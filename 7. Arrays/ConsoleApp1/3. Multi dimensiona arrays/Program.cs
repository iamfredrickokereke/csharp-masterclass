using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Multi_dimensiona_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2d array
            string[,] matrix;

            //3D array
            int[,,] treeD;

            // Two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 }, //row 0
                {4,5,6 }, //row 1
                {7,8,9 }  //row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("Value is {0}", array2D[2, 0]);


            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi there", "What's up" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry" }
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two", },
                { "three", "four" },
                { "five", "six" }
            };

            array2DString[1, 1] = "Chicken";

            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 1, 2 } };

            Console.WriteLine("The value is {0}", array3D[1, 2, 1]);
            Console.WriteLine("The value is {0}", array2DString[1, 1]);
            Console.WriteLine("Dimensions {0}", dimensions);



            Console.Read();


        }
    }
}
