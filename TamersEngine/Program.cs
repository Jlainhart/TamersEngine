using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersStats;
using Value;

namespace TamersEngine
{

    public class Engine
    {
        static void Main()
        {
            // intro fill in info
            

                Console.WriteLine("Enter UserName:");

                Values.userName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{Values.userName}, Iv been waiting for you.");

                Thread.Sleep(2000);

            Values.digiDeath = true;
            while (Values.digiDeath)
            {
                Console.Clear();

                EggStats.StatPer();
                Images.Egg();
                Thread.Sleep(2000);
                Console.Clear();
                Images.Hatch();
                Thread.Sleep(2000);

                Values.digiDeath = false;
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

            Console.WriteLine($"UserName: {Values.userName}");
            Console.WriteLine($"DigiName: {Values.digiName}");
            Console.WriteLine($"\nDigi: {Values.digi}  Level: {Values.lvl}  Health: {Values.hp} Mental: {Values.mp}\nAttack: {Values.atk}  Defense: {Values.def}  Intellagence: {Values.intel}  Speed: {Values.spd}\nType: {Values.type} Attribute: {Values.attribute}  Species: {Values.species}  Personality:{Values.per} \nEnergy: {Values.energy}  Vitality: {Values.sick}  Experiance: {Values.exp}  Mood: {Values.mood}\nTired: {Values.tired}  Sleep: {Values.sleep}  Hunger: {Values.hunger}  Poop: {Values.poop}  Age: {Values.age}");

            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();
        }        

    }
}
    
  
