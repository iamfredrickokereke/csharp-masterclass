using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chalenge
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = 12318925;
            Console.WriteLine(myInt);
            uint myUint = 123091;
            Console.WriteLine(myUint);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUshort = 65535;
            Console.WriteLine(myUshort);
            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);
            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);
            char myChar = 'A';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string myNum = "15";

            int myNumFromText = int.Parse(myNum);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
