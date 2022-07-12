using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersEngine;

namespace TamersStats
{
    class EggStats
    {
        public static void StatPer()
        {
            /*static String GetTimestamp(DateTime value)
                {
                    return value.ToString("MM-dd-yyyy-HH-mm");
                    string timeStamp = GetTimestamp(DateTime.Now);
                }*/


            Console.Clear();
            Console.WriteLine("Enter Digimon Name:");

            Engine.digiName = Console.ReadLine();
            Console.Clear();

            string[] personality = new string[] { "Durable", "Lively", "Fighter", "Defender", "Brainy", "Nimble" };
            Random rnd = new Random();
            int index = rnd.Next(personality.Length);
            Engine.per = personality[index];


            int lvl = 0;
            int hp = 100;
            int mp = 100;
            int atk = 10;
            int def = 10;
            int intel = 10;
            int spd = 10;
            int energy = 50;
            // how much exploring or battles can be done before rest, sleep.
            int sick = 0;
            // how sick it is

            int exp = 0;
            switch (exp)
            {
                case int x when (x < 99):
                    lvl = 0;
                    break;
                case int x when (x >= 100 && x <= 199):
                    lvl++;
                    break;
                case int x when (x <= 299 && x >= 200):
                    lvl += 2;
                    break;
                case int x when (x <= 399 && x >= 300):
                    lvl += 3;
                    break;
                case int x when (x < 499 && x >= 400):
                    lvl += 4;
                    break;
                case int x when (x < 599 && x >= 500):
                    lvl += 5;
                    break;
            }

            int mood = 100;
            // - if hunger 0, poop 100, tired 50, vitality 100 or sleepy.

            int tired = 0;
            if (tired >= 50)//half training points half energy
            {
                energy = -25;
            }
            else if (tired == 100)// no energy no training points
            {
                energy = -50;
            }
            else
            {
            }


            int sleep = 000000;
            // sleep at night?, removes tired, 3 hour day-3 hour night(pc)
            // digivice(phone) will be real time sync
            int hunger = 100;
            // hunger -= 5 every 5 min
            if (hunger <= 50)//display hungry image
            {

            }
            else if (hunger == 0)// energy goes to 0
            {
                energy = -50;
            }
            else
            {

            };


            int poop = 0;
            if (poop == 100)//display poop image
            {
                sick += 1;
                // every 5 min
            }
            else
            {

            };

            int age = 0;

            int minAge = 0;
            int maxAge = 60;
            if (age == maxAge)//restarts to egg
            {
                //digiDeath = true;
            }
            else
            {

            };

            // needs to pull from specific digimon
            string digi = "digi";
            string type = "type";
            string attribute = "att";
            string species = "species";




            switch (Engine.per)
            {
                case "Durable":
                    hp += 50 + lvl * 10;
                    break;
                case "Lively":
                    mp += 50 + lvl * 10;
                    break;
                case "Fighter":
                    atk += 5 + lvl * 1;
                    break;
                case "Defender":
                    def += 5 + lvl * 1;
                    break;
                case "Brainy":
                    intel += 5 + lvl * 1;
                    break;
                case "Nimble":
                    spd += 5 + lvl * 1;
                    break;
            }

        }
    }

    class Images
    {
        public static void Egg()
        {
            Console.WriteLine("                    ■■       ");
            Console.WriteLine("                  ■    ■     ");
            Console.WriteLine("                ■        ■   ");
            Console.WriteLine("               ■          ■  ");
            Console.WriteLine("              ■            ■ ");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("               ■          ■  ");
            Console.WriteLine("                 ■ ■■■■ ■    ");
        }

        public static void Hatch()
        {
            Console.WriteLine("                    ■■       ");
            Console.WriteLine("                  ■    ■     ");
            Console.WriteLine("                ■        ■   ");
            Console.WriteLine("              ■            ■ ");
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
            Console.WriteLine("              ■  ■      ■  ■ ");
            Console.WriteLine("              ■    ■■■■    ■ ");
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("               ■          ■  ");
            Console.WriteLine("                 ■ ■■■■ ■    ");
        }

        public static void Baby()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                  ■ ■■■■ ■   ");
            Console.WriteLine("                ■          ■ ");
            Console.WriteLine("               ■  ■      ■  ■");
            Console.WriteLine("               ■    ■■■■    ■");
            Console.WriteLine("               ■            ■");
            Console.WriteLine("                ■          ■ ");
            Console.WriteLine("                  ■ ■■■■ ■   ");
        }

        public static void Teen()
        {
            Console.WriteLine();
            Console.WriteLine("                  ■ ■■■■ ■■   ");
            Console.WriteLine("                ■           ■  ");
            Console.WriteLine("               ■  ■       ■  ■ ");
            Console.WriteLine("               ■    ■■■■■    ■ ");
            Console.WriteLine("              ■■             ■■");
            Console.WriteLine("                ■           ■  ");
            Console.WriteLine("                 ■    ■    ■   ");
            Console.WriteLine("                  ■  ■ ■  ■   ");
            Console.WriteLine("                   ■     ■     ");
        }

        public static void Adult()
        {
            Console.WriteLine("                   ■       ■     ");
            Console.WriteLine("                  ■■■■   ■■■■    ");
            Console.WriteLine("                 ■■■■■■■■■■■■■   ");
            Console.WriteLine("                 ■           ■   ");
            Console.WriteLine("                ■  ■       ■  ■  ");
            Console.WriteLine("                ■     ■■■     ■  ");
            Console.WriteLine("              ■■■             ■■■");
            Console.WriteLine("                 ■           ■   ");
            Console.WriteLine("                  ■    ■    ■    ");
            Console.WriteLine("                   ■  ■ ■  ■     ");
            Console.WriteLine("                    ■     ■      ");

        }

        public static void Dead()
        {
            Console.WriteLine("                   ■ ■ ■ ■      ");
            Console.WriteLine("                   ■     ■      ");
            Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■");
            Console.WriteLine("             ■      R.I.P.     ■");
            Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■");
            Console.WriteLine("                   ■     ■      ");
            Console.WriteLine("                   ■     ■      ");
            Console.WriteLine("                   ■     ■      ");
            Console.WriteLine("                   ■     ■      ");
            Console.WriteLine("                   ■     ■      ");
            Console.WriteLine("                   ■ ■ ■ ■      ");
        }


    }

}

