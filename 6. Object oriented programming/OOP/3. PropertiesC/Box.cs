using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PropertiesC
{
    class Box
    {
        //member variable
        private int length;
        private int height;
        //private int width;
        private int volume;

        // auto - implemented property - prop
        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        //write only
        public int Volume {
            get
            {
                return Height * Width * Length;
            }
            set
            {
                volume = value;
            }
        }

        //read only
        public int Height {
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
                    //throw new Exception("Size should be positive");
                }
                height = value;
            }
            */
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        /*
        // set
        public void SetLenght(int length)
        {
            this.length = length;
        }
        
        // get
        public int GetLenght()
        {
            return this.length;
        }
        */
        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and height is {1} and width is {2}, so the volume is {3}", length, height, Width, length * height * Width);
        }
    }
}
