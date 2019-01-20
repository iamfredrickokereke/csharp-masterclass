﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PolymorphysmC
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }


        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //default construtor
        public Car()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + " color: " + Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

    }
}
