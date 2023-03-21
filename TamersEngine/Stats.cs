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
        public static void StatPer(Values values)
        {

                
            values.timeStampBorn = DateTime.Now;
                
            Console.Clear();
            Console.WriteLine("Enter Digimon Name:");


            values.digiName = Console.ReadLine();
            while (values.digiName.Length < 3)
            {
                Console.Clear();
                Console.WriteLine("Digimon Name must be atleast 1 character.");
                Console.WriteLine("Enter UserName:");
                values.digiName = Console.ReadLine();
            }
            Console.Clear();

            string[] personality = new string[] { "Durable", "Lively", "Fighter", "Defender", "Brainy", "Nimble" };
            Random rnd = new Random();
            int index = rnd.Next(personality.Length);
            values.per = personality[index];

            string[] Mon = new string[] { "Botamon", "Chibomon", "Jyarimon", "Punimon" };
            Random rand = new Random();
            int i = rnd.Next(Mon.Length);
            values.digi = Mon[i];

            values.lvl = 0;
            values.hp = 100;
            values.minhp = 0;
            values.maxhp = 100;
            values.mp = 100;
            values.minmp = 0;
            values.maxmp = 100;
            values.atk = 10;
            values.def = 10;
            values.intel = 10;
            values.spd = 10;
            values.energy = 50;
            values.minenergy = 0;
            values.maxenergy = 50;
            // how much exploring or battles can be done before rest, sleep.
            values.sick = 0;
            values.minsick = 0;
            values.maxsick = 100;
            // how sick it is
            values.exp = 0;
            values.mood = 100;
            // - if hunger 0, poop 100, tired 50, vitality 100 or sleepy.
            values.tired = 0;
            values.mintired = 0;
            values.maxtired = 100;
            values.sleep = 000000;
            // sleep at night?, removes tired, 3 hour day-3 hour night(pc)
            // digivice(phone) will be real time sync
            values.fullness = 100;
            values.minfullness = 0;
            values.maxfullness = 100;
            // hunger -= 5 every 10 min
            values.poop = 0;
            values.minpoop = 0;
            values.maxpoop = 100;
            values.age = 0;
            values.minAge = 0;
            values.maxAge = 60;

            switch (values.digi)
            {
                case "Botamon":
                    Mons.Botamon(values);
                    break;
                case "Chibomon":
                    Mons.Chibomon(values);
                    break;
                case "Jyarimon":
                    Mons.Jyarimon(values);
                    break;
                case "Punimon":
                    Mons.Punimon(values);
                    break;
            }

            switch (values.per)
            {
                case "Durable":
                    values.maxhp += 50;
                    break;
                case "Lively":
                    values.maxmp += 50;
                    break;
                case "Fighter":
                    values.atk += 5;
                    break;
                case "Defender":
                    values.def += 5;
                    break;
                case "Brainy":
                    values.intel += 5;
                    break;
                case "Nimble":
                    values.spd += 5;
                    break;
            }

            //egg hatching

            Images.Egg();
            Thread.Sleep(500);
            Console.Clear();
            Images.Egg1();
            Thread.Sleep(500);
            Console.Clear();
            Images.Egg();
            Thread.Sleep(500);
            Console.Clear();
            Images.Egg2();
            Thread.Sleep(500);
            Console.Clear();
            Images.Egg();
            Thread.Sleep(500);
            Console.Clear();
            Images.Hatch();
            Thread.Sleep(500);
            Console.Clear();
            Images.Hatch1();
            Thread.Sleep(500);
            Console.Clear();
            Images.Hatch2();
            Thread.Sleep(500);

            values.digiDeath = false;
        }

            public static void Checkstat(Values values)
        {
            Console.Clear();

            DateTime currentTime = DateTime.Now;
            TimeSpan timeDifference = currentTime - values.timeStampBorn;
            values.age = (int)timeDifference.TotalDays;

            while (values.hp < values.maxhp)
            {
                values.hp += 5;
                //Thread.Sleep(10000);
            } 
            

            while (values.mp < values.maxmp)
            {
                values.mp += 5;
                //Thread.Sleep(10000);
            }
            
            if (values.sick == values.maxsick)//restarts to egg
            {
                values.digiDeath = true;
            }


            switch (values.exp)//find simple math problem to increase exp needed per level
            {
                case int x when (x < 99):
                    values.lvl = 0;
                    break;
                case int x when (x >= 100 && x <= 199):
                    values.lvl++;
                    break;
                case int x when (x <= 299 && x >= 200):
                    values.lvl += 2;
                    break;
                case int x when (x <= 399 && x >= 300):
                    values.lvl += 3;
                    break;
                case int x when (x < 499 && x >= 400):
                    values.lvl += 4;
                    break;
                case int x when (x < 599 && x >= 500):
                    values.lvl += 5;
                    break;
            }


            if (values.tired >= 50)//half training points half energy
            {
                values.energy = -25;
            }
            else if (values.tired == 100)// no energy no training points
            {
                values.energy = -50;
            }
            else
            {
            }



            
            if (values.fullness <= 50)//display hungry image
            {

            }
            else if (values.fullness == 0)// energy goes to 0
            {
                values.energy = -50;
            }
            else
            {

            }



            if (values.poop == 100)//display poop image
            {
                values.sick += 1;
                // every 5 min
            }
            else
            {

            }

            if (values.age == values.maxAge)//restarts to egg
            {
                //Values.digiDeath = true;
            }
            else
            {

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
            Console.WriteLine("             ■                 ■");
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

