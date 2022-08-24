﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersStats;
using Value;
using Inventory;
using Digis;

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
                //egg hatching
                EggStats.StatPer();
                Images.Egg();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Egg1();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Egg();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Egg2();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Egg();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Hatch();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Hatch1();
                Thread.Sleep(1000);
                Console.Clear();
                Images.Hatch2();
                Thread.Sleep(1000);

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
            Console.WriteLine($"Level: {Values.lvl}  Health: {Values.hp}/ {Values.maxhp} \nMental: {Values.mp}/ {Values.maxmp} Energy: {Values.energy}");
            //show mon image Values.mon
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

            Console.WriteLine("\n1) Health \n2) Mana \n3) Attack \n4) Defence \n5) Speed \n6) Intellagence");
            Console.Write("\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //start 30 min timer
                            if (Values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");
                                
                            }
                            else
                            {
                                Values.maxhp += 40;
                                Values.maxmp -= 10;
                                Values.fullness -= 10;
                                Values.tired += 10;
                                Values.energy -= 5;
                                Values.exp += 5;
                                Console.WriteLine("Health Increased by 40 and Mana Decreased by 10");
                              
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (Values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");
                            }
                            else
                            {
                                Values.maxhp += 80;
                                Values.fullness -= 20;
                                Values.tired += 20;
                                Values.energy -= 10;
                                Values.exp += 10;
                                Console.WriteLine("Health Increased by 80");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (Values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");
                            }
                            Values.maxhp += 150;
                            Values.maxmp += 70;
                            Values.fullness -= 40;
                            Values.tired += 40;
                            Values.energy -= 20;
                            Values.exp += 20;
                            Console.WriteLine("Health Increased by 150 and Mana Increased by 70");
                            break;
                        default:
                            return;

                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (Values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                //start 30 min timer
                                Values.maxmp += 40;
                                Values.maxhp -= 10;
                                Values.fullness -= 15;
                                Values.tired += 10;
                                Values.energy -= 5;
                                Values.exp += 5;
                                Console.WriteLine("Mana Increased by 40 and Health Decreased by 10");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (Values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.maxmp += 80;
                                Values.fullness -= 30;
                                Values.tired += 20;
                                Values.energy -= 10;
                                Values.exp += 10;
                                Console.WriteLine("Mana Increased by 80");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (Values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.maxmp += 150;
                                Values.maxhp += 70;
                                Values.fullness -= 60;
                                Values.tired += 40;
                                Values.energy -= 20;
                                Values.exp += 20;
                                Console.WriteLine("Mana Increased by 150 and Mana Increased by 70");
                            }
                            break;
                        default:
                            return;

                    }
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //start 30 min timer
                            if (Values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.atk += 4;
                                Values.def -= 1;
                                Values.fullness -= 15;
                                Values.tired += 10;
                                Values.energy -= 5;
                                Values.exp += 5;
                                Console.WriteLine("Attack Increased by 4 and Defence Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (Values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.atk += 7;
                                Values.fullness -= 30;
                                Values.tired += 20;
                                Values.energy -= 10;
                                Values.exp += 10;
                                Console.WriteLine("Attack Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (Values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.atk += 13;
                                Values.def += 3;
                                Values.fullness -= 60;
                                Values.tired += 40;
                                Values.energy -= 20;
                                Values.exp += 20;
                                Console.WriteLine("Attack Increased by 13 and Defence Decreased by 3");
                            }
                            break;
                        default:
                            return;

                    }
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //start 30 min timer
                            if (Values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.def += 4;
                                Values.atk -= 1;
                                Values.fullness -= 15;
                                Values.tired += 10;
                                Values.energy -= 5;
                                Values.exp += 5;
                                Console.WriteLine("Defence Increased by 4 and Attack Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (Values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.def += 7;
                                Values.fullness -= 30;
                                Values.tired += 20;
                                Values.energy -= 10;
                                Values.exp += 10;
                                Console.WriteLine("Defence Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (Values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.def += 13;
                                Values.atk += 3;
                                Values.fullness -= 60;
                                Values.tired += 40;
                                Values.energy -= 20;
                                Values.exp += 20;
                                Console.WriteLine("Defence Increased by 13 and Attack Increased by 3");
                            }
                            break;
                        default:
                            return;
                    }
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //start 30 min timer
                            if (Values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.spd += 4;
                                Values.intel -= 1;
                                Values.fullness -= 15;
                                Values.tired += 10;
                                Values.energy -= 5;
                                Values.exp += 5;
                                Console.WriteLine("Speed Increased by 4 and Intellagence Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (Values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.spd += 7;
                                Values.fullness -= 30;
                                Values.tired += 20;
                                Values.energy -= 10;
                                Values.exp += 10;
                                Console.WriteLine("Speed Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (Values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.spd += 13;
                                Values.intel += 3;
                                Values.fullness -= 60;
                                Values.tired += 40;
                                Values.energy -= 20;
                                Values.exp += 20;
                                Console.WriteLine("Speed Increased by 13 and Intellagence Increased by 3");
                            }
                            break;
                        default:
                            return;

                    }
                    break;


                case "6":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //start 30 min timer
                            if (Values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.intel += 4;
                                Values.spd -= 1;
                                Values.fullness -= 15;
                                Values.tired += 10;
                                Values.energy -= 5;
                                Values.exp += 5;
                                Console.WriteLine("Intellagence Increased by 4 and Speed Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (Values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.intel += 7;
                                Values.fullness -= 30;
                                Values.tired += 20;
                                Values.energy -= 10;
                                Values.exp += 10;
                                Console.WriteLine("Intellagence Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (Values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else
                            {
                                Values.intel += 13;
                                Values.spd += 3;
                                Values.fullness -= 60;
                                Values.tired += 40;
                                Values.energy -= 20;
                                Values.exp += 20;
                                Console.WriteLine("Intellagence Increased by 13 and Speed Increased by 3");
                            }
                            break;
                        default:
                            return;

                    }

                    break;

                default:
                    return;

            }
  

            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();


        }

        static void Items()
        {
            Console.Clear();
            Console.WriteLine("Items");

            Console.WriteLine("\n1) Food \n2) Pills \n3) Health \n4) Mana \n5) Cure");
            Console.Write("\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\n1) Nugget \n2) Meat \n3) Large Meat \n4) Sirloin");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Item.Nugget();
                            break;
                        case "2":
                            Item.Meat();
                            break;
                        case "3":
                            Item.LargeMeat();
                            break;
                        case "4":
                            // sirloin
                            break;
                        default:
                            return;
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\n1) Pill 2) KillPill");
                    Console.Write("\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Item.Pill();
                            break;
                        case "2":
                            Item.KillPill();
                            break;
                        default:
                            return;
                    }

                    break;
                default:
                    break;
            }

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
            Console.WriteLine($"\nDigi: {Values.digi}  \nAttack: {Values.atk}  Defense: {Values.def}  \nIntellagence: {Values.intel}  Speed: {Values.spd}" +
                $"\nType: {Values.type} Attribute: {Values.attribute}  Species: {Values.species}  Personality:{Values.per} " +
                $"\nVitality: {Values.sick}  Experiance: {Values.exp}  Mood: {Values.mood}" +
                $"\nTired: {Values.tired}  Sleep: {Values.sleep}  Hunger: {Values.fullness}  Poop: {Values.poop}  Age: {Values.age}");

            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();
        }

    }
}
    
  
