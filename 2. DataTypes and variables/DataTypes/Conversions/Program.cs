using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // implict conversion
            int num = 123245436;
            long biigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;

            // explict conversion
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBool = sunIsShining.ToString();

            Console.WriteLine(myBool);
            Console.WriteLine(myFloatString);
            Console.Read();
        }
    }
}
