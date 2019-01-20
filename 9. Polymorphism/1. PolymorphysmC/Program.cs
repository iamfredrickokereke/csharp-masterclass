using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PolymorphysmC
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(259, "black", "M3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            //Casting
            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}