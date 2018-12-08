using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PropertiesC
{
    class Box
    {
        // membet variables
        private int length;
        private int height;
        //private int width;
        private int volume;

        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        // auto - impelemeted property = enter "prop" + press double tab
        

        public int Volume
        {
            get
            {
                return Height * Width * Length;
            }
            set
            {
                Volume = value;
            }
        }

        // read only
        public int Height
        {
            get
            {
                return height;
            }
            /*
            set
            {
                if (value < 0)
                {
                    value = -value;
                    //throw new Exception("Size should be pozitive");
                }
                height = value;
            }
            */
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        /*
        public void SetLenght(int length)
        {
            this.lenght = length;
        }
        */

        /*
        public int GetLength()
        {
            return this.length;
        }
        */

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and height is {1} and width is {2}, so the volume is {3}", Length, height, Width, volume = Width * height * Length);
        }
    }
}
