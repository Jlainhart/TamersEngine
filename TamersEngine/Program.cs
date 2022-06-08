using System;
using System.Collections.Generic;
using System.Timers;

namespace TamersEngine
{

    class Engine
    {
        static void Main(string[] args)
        {
            // intro fill in info
            string userName;
            Console.WriteLine("Enter UserName:");

            userName = Console.ReadLine();


            string digiName;
            Console.Clear();
            Console.WriteLine("Enter Digimon Name:");

            digiName = Console.ReadLine();


            // Egg hatches
            void HandleTimer()
            {
                Console.WriteLine($"{userName}, Iv been waiting for you.");


                System.Timers.Timer timer = new(interval: 1000);
                timer.Elapsed += (sender, e) => HandleTimer();
                timer.Start();

                Console.ReadLine();
                System.Threading.Thread.Sleep(10000);

                timer.Dispose();
            }

            // begin main menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Home();
            }



            static bool Home()
            {
                Console.Clear();
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


                Console.WriteLine("1) Train 2) Feed 3) Stats 4) Exit");
                Console.Write("\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Train();
                        return true;
                    case "2":
                        Items();
                        return true;
                    case "3":
                        Stats();
                        return true;
                    case "4":
                        return false;
                    default:
                        return true;
                }

            }

            static void Train()
            {
                Console.Clear();
                Console.WriteLine("Train");

                // 30 min
                // 1 hour
                // 2 hour

                // hp (mp)
                // mp (hp)
                // attack (int)
                // defence (spd)
                // speed (def)
                // intellanence (atk)

                Console.WriteLine("\nPress Enter to return");
                Console.ReadLine();


            }

            static void Items()
            {
                Console.Clear();
                Console.WriteLine("Items");

                // increase food
                // nugget 
                // meat
                // large meat
                // sirloin

                // restore energy
                // pill

                // restore health
                // bandaid
                // med kit

                // restore mana
                // vial
                // potion

                // cure sickness
                // vaccine
                Console.WriteLine("\nPress Enter to return");
                Console.ReadLine();


            }

            static void Stats()
            {
                Console.Clear();
                Console.WriteLine("Stats");

                int lvl = 0;
                int hp = 100;
                int mp = 100;
                int atk = 10;
                int def = 10;
                int intel = 10;
                int spd = 10;
                int energy = 50;
                // how much exploring or battles can be done before rest, sleep.
                int vitality = 0;
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

                };

                int sleep = 000000;
                // sleep at night?, removes tired, 3 hour day-3 hour night(pc)
                // digivice(phone) will be real time sync
                int hunger = 100;
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
                    vitality += 1;
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
                    //while statement around code?
                }
                else
                {

                };

                string digi = "digi";
                string type = "type";
                string attribute = "att";
                string species = "species";

                string[] personality = new string[] { "Durable", "Lively", "Fighter", "Defender", "Brainy", "Nimble" };
                Random rnd = new Random();
                int index = rnd.Next(personality.Length);
                switch (personality[index])
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

                //Console.WriteLine($"UserName: {userName}");
                //Console.WriteLine($"DigiName: {digiName}");
                Console.WriteLine($"\nDigi: {digi}  Level: {lvl}  Health: {hp} Mental: {mp}\nAttack: {atk}  Defense: {def}  Intellagence: {intel}  Speed: {spd}\nType: {type} Attribute: {attribute}  Species: {species}  Personality: {personality[index]}\nEnergy: {energy}  Vitality: {vitality}  Experiance: {exp}  Mood: {mood}\nTired: {tired}  Sleep: {sleep}  Hunger: {hunger}  Poop: {poop}  Age: {age}");

                Console.WriteLine("\nPress Enter to return");
                Console.ReadLine();


            }

        }

        void Egg()
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

        void Hatch()
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

        void Baby()
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

        void Teen()
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

        void Adult()
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

        void Dead()
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
