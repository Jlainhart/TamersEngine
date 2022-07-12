using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersStats;

namespace TamersEngine
{

    public class Engine
    {
        public static string userName { get; set; }
        public static string per { get; set; }
        public static string digiName { get; set; }
        public static bool digiDeath { get; set; }

        static void Main()
        {
            // intro fill in info
            

                Console.WriteLine("Enter UserName:");

                userName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{userName}, Iv been waiting for you.");

                Thread.Sleep(2000);

            digiDeath = true;
            while (digiDeath)
            {
                Console.Clear();

                EggStats.StatPer();
                Images.Egg();
                Thread.Sleep(2000);

                Images.Hatch();
                Thread.Sleep(2000);

                digiDeath = false;
            }


            

           
            // begin main menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Home();
            }
        }


        static bool Home()
        {
            Console.Clear();
            //digimons image
            Console.WriteLine("\n1) Train \n2) Feed \n3) Stats \n4) Save and Exit");
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

            Console.WriteLine($"UserName: {userName}");
            Console.WriteLine($"DigiName: {digiName}");
            Console.WriteLine($"\nDigi: {digi}  Level: {lvl}  Health: {hp} Mental: {mp}\nAttack: {atk}  Defense: {def}  Intellagence: {intel}  Speed: {spd}\nType: {type} Attribute: {attribute}  Species: {species}  Personality:{per} \nEnergy: {energy}  Vitality: {sick}  Experiance: {exp}  Mood: {mood}\nTired: {tired}  Sleep: {sleep}  Hunger: {hunger}  Poop: {poop}  Age: {age}");

            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();
        }        

    }
}
    
  
