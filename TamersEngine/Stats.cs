using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersEngine;
using Value;
using Inventory;
using Digis;

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

            Values.digiName = Console.ReadLine();
            Console.Clear();

            string[] personality = new string[] { "Durable", "Lively", "Fighter", "Defender", "Brainy", "Nimble" };
            Random rnd = new Random();
            int index = rnd.Next(personality.Length);
            Values.per = personality[index];

            string[] Mon = new string[] { "Botamon", "Chibomon", "Jyarimon", "Punimon" };
            Random rand = new Random();
            int i = rnd.Next(Mon.Length);
            Values.digi = Mon[i];

            Values.lvl = 0;
            Values.hp = 100;
            Values.minhp = 0;
            Values.maxhp = 100;
            while (Values.hp < Values.maxhp)
            {
                Values.hp =+5;
                Thread.Sleep(10000);
            }
            Values.mp = 100;
            Values.minmp = 0;
            Values.maxmp = 100;
            while (Values.mp < Values.maxmp)
            {
                Values.hp = +5;
                Thread.Sleep(10000);
            }
            Values.atk = 10;
            Values.def = 10;
            Values.intel = 10;
            Values.spd = 10;
            Values.energy = 50;
            Values.minenergy = 0;
            Values.maxenergy = 50;
            // how much exploring or battles can be done before rest, sleep.
            Values.sick = 0;
            Values.minsick = 0;
            Values.maxsick = 1000;
            // how sick it is

            Values.exp = 0;
            switch (Values.exp)
            {
                case int x when (x < 99):
                    Values.lvl = 0;
                    break;
                case int x when (x >= 100 && x <= 199):
                    Values.lvl++;
                    break;
                case int x when (x <= 299 && x >= 200):
                    Values.lvl += 2;
                    break;
                case int x when (x <= 399 && x >= 300):
                    Values.lvl += 3;
                    break;
                case int x when (x < 499 && x >= 400):
                    Values.lvl += 4;
                    break;
                case int x when (x < 599 && x >= 500):
                    Values.lvl += 5;
                    break;
            }

            Values.mood = 100;
            // - if hunger 0, poop 100, tired 50, vitality 100 or sleepy.

            Values.tired = 0;
            Values.mintired = 0;
            Values.maxtired = 100;
            if (Values.tired >= 50)//half training points half energy
            {
                Values.energy = -25;
            }
            else if (Values.tired == 100)// no energy no training points
            {
                Values.energy = -50;
            }
            else
            {
            }


            Values.sleep = 000000;
            // sleep at night?, removes tired, 3 hour day-3 hour night(pc)
            // digivice(phone) will be real time sync
            Values.hunger = 100;
            Values.minhunger = 0;
            Values.maxhunger = 100;
            // hunger -= 5 every 10 min
            if (Values.hunger <= 50)//display hungry image
            {

            }
            else if (Values.hunger == 0)// energy goes to 0
            {
                Values.energy = -50;
            }
            else
            {

            };


            Values.poop = 0;
            Values.minpoop = 0;
            Values.maxpoop = 100;
            if (Values.poop == 100)//display poop image
            {
                Values.sick += 1;
                // every 5 min
            }
            else
            {

            };

            Values.age = 0;

            Values.minAge = 0;
            Values.maxAge = 60;
            if (Values.age == Values.maxAge)//restarts to egg
            {
                Values.digiDeath = true;
            }
            else
            {

            };

            // needs to pull from specific digimon
            switch (Values.digi)
            {
                case "Botamon":                   
                    Mons.Botamon();
                    break;
                case "Chibomon":
                    Mons.Chibomon();
                    break;
                case "Jyarimon":
                    Mons.Jyarimon();
                    break;
                case "Punimon":
                    Mons.Punimon();
                    break;
            }
            




            switch (Values.per)
            {
                case "Durable":
                    Values.hp += 50 + Values.lvl * 10;
                    break;
                case "Lively":
                    Values.mp += 50 + Values.lvl * 10;
                    break;
                case "Fighter":
                    Values.atk += 5 + Values.lvl * 1;
                    break;
                case "Defender":
                    Values.def += 5 + Values.lvl * 1;
                    break;
                case "Brainy":
                    Values.intel += 5 + Values.lvl * 1;
                    break;
                case "Nimble":
                    Values.spd += 5 + Values.lvl * 1;
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
        public static void Egg1()
        {
            Console.WriteLine("                     ■■       ");
            Console.WriteLine("                   ■    ■     ");
            Console.WriteLine("                 ■        ■   ");
            Console.WriteLine("                ■          ■  ");
            Console.WriteLine("               ■            ■ ");
            Console.WriteLine("              ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("               ■          ■  ");
            Console.WriteLine("                 ■ ■■■■ ■    ");
        }
        public static void Egg2()
        {
            Console.WriteLine("                   ■■       ");
            Console.WriteLine("                 ■    ■     ");
            Console.WriteLine("               ■        ■   ");
            Console.WriteLine("              ■          ■  ");
            Console.WriteLine("             ■            ■ ");
            Console.WriteLine("            ■              ■");
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
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("               ■          ■  ");
            Console.WriteLine("                 ■ ■■■■ ■    ");
        }
        public static void Hatch1()
        {
            Console.WriteLine("                    ■■       ");
            Console.WriteLine("                  ■    ■     ");
            Console.WriteLine("                ■        ■   ");
            Console.WriteLine("              ■            ■ ");
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
            Console.WriteLine("              ■  ■      ■  ■ ");
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("             ■              ■");
            Console.WriteLine("               ■          ■  ");
            Console.WriteLine("                 ■ ■■■■ ■    ");
        }
        public static void Hatch2()
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

