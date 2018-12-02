﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Chalenge2
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Mantas";

        static void Main(string[] args)
        {
            CheckHighscore(250, "Maria");
            CheckHighscore(315, "Denis");
            CheckHighscore(350, "Mantas");

            Console.Read();
        }

        public static void CheckHighscore (int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore cound not be broken. It is still " + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}
