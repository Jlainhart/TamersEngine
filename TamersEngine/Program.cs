using System;
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
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace TamersEngine
{

    public class Engine
    {


        static void Main()
        {
            Values data = new Values();
            Values values = new Values();
            Console.Clear();
            Console.WriteLine("\n1) Continue \n2) New Game \n3) Options");
            Console.Write("\nSelect an option: ");

            switch (Console.ReadLine())
                {
                    case "1":
                        Values value = LoadData("filename");
                        Home(data, values);                   
                    break;
                    case "2":
                        NewGame(values);
                    break;
                    case "3":
                    //Options();
                    //Console.Clear();
                        Main();
                    break;
                    default:
                        Main();
                    break;
                }
            

            static void NewGame(Values values)
            {
                Console.Clear();
                Console.WriteLine("Enter UserName:");
                values.userName = Console.ReadLine();

                while (values.userName.Length < 3)
                {
                    Console.Clear();
                    Console.WriteLine("UserName must be atleast 3 characters.");
                    Console.WriteLine("Enter UserName:");
                    values.userName = Console.ReadLine();
                }
                /*while (Values.userName.Equals(Values.badWords))
                {
                 Console.Clear();
                 Console.WriteLine("UserName is in use or not allowed.");
                 Console.WriteLine("Enter UserName:");            
                 Values.userName = Console.ReadLine();
                }*/

                Console.Clear();
                Console.WriteLine($"{values.userName}, Iv been waiting for you.");

                Thread.Sleep(2000);

                EggStats.StatPer(values);
              
            }

            // begin main menu            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Home(data, values);
            }


        }



        public static bool Home(Values data, Values values)            
        {
            if (values.digiDeath == false)
            {
                EggStats.Checkstat(values);
                
            }
            
            if (values.digiDeath == true)
            {
                Images.Dead();
                Console.WriteLine($"{values.digiName} Has Degenerated back into a Digi Egg!.");
                Thread.Sleep(5000);
                EggStats.StatPer(values);
            }
           

            Console.Clear();
            Console.WriteLine($"Level: {values.lvl}  Health: {values.hp}/ {values.maxhp} \nMental: {values.mp}/ {values.maxmp} Energy: {values.energy}");
            //show mon image Values.mon
            Console.WriteLine("\n1) Train \n2) Feed \n3) Stats \n4) Save and Exit");
            Console.Write("\nSelect an option: ");            
            
            switch (Console.ReadLine())
            {
                case "1":
                    Train(data, values);
                    return true;
                case "2":
                    Items(data, values);
                    return true;
                case "3":
                    Stats(data, values);
                    return true;
                case "4":
                    SaveData(data, "filename");
                    return false;
                default:
                    return true;
            }

        }

        static void Train(Values data, Values values)
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
                            if (values.energy < 5)
                            {
                                Console.WriteLine("Not enough Energy!");
                                
                            }
                            else if (values.fullness < 5)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.maxhp += 40;
                                values.maxmp -= 10;
                                values.fullness -= 5;
                                values.tired += 10;
                                values.energy -= 5;
                                values.exp += 5;
                                Console.WriteLine("Health Increased by 40 and Mana Decreased by 10");
                              
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");
                            }
                            else if (values.fullness < 10)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.maxhp += 80;
                                values.fullness -= 10;
                                values.tired += 20;
                                values.energy -= 10;
                                values.exp += 10;
                                Console.WriteLine("Health Increased by 80");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");
                            }
                            else if (values.fullness < 20)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.maxhp += 150;
                                values.maxmp += 70;
                                values.fullness -= 20;
                                values.tired += 40;
                                values.energy -= 20;
                                values.exp += 20;
                                Console.WriteLine("Health Increased by 150 and Mana Increased by 70");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose again");
                            break;

                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\n1) 30 Min \n2) 1 Hour \n3) 2 Hour");
                    Console.Write("\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 5)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                //start 30 min timer
                                values.maxmp += 40;
                                values.maxhp -= 10;
                                values.fullness -= 5;
                                values.tired += 10;
                                values.energy -= 5;
                                values.exp += 5;
                                Console.WriteLine("Mana Increased by 40 and Health Decreased by 10");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 10)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.maxmp += 80;
                                values.fullness -= 10;
                                values.tired += 20;
                                values.energy -= 10;
                                values.exp += 10;
                                Console.WriteLine("Mana Increased by 80");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 20)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.maxmp += 150;
                                values.maxhp += 70;
                                values.fullness -= 20;
                                values.tired += 40;
                                values.energy -= 20;
                                values.exp += 20;
                                Console.WriteLine("Mana Increased by 150 and Mana Increased by 70");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose again");
                            break;

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
                            if (values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 5)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.atk += 4;
                                values.def -= 1;
                                values.fullness -= 5;
                                values.tired += 10;
                                values.energy -= 5;
                                values.exp += 5;
                                Console.WriteLine("Attack Increased by 4 and Defence Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 10)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.atk += 7;
                                values.fullness -= 10;
                                values.tired += 20;
                                values.energy -= 10;
                                values.exp += 10;
                                Console.WriteLine("Attack Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 20)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.atk += 13;
                                values.def += 3;
                                values.fullness -= 20;
                                values.tired += 40;
                                values.energy -= 20;
                                values.exp += 20;
                                Console.WriteLine("Attack Increased by 13 and Defence Increased by 3");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose again");
                            break;

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
                            if (values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 5)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.def += 4;
                                values.atk -= 1;
                                values.fullness -= 5;
                                values.tired += 10;
                                values.energy -= 5;
                                values.exp += 5;
                                Console.WriteLine("Defence Increased by 4 and Attack Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 10)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.def += 7;
                                values.fullness -= 10;
                                values.tired += 20;
                                values.energy -= 10;
                                values.exp += 10;
                                Console.WriteLine("Defence Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 20)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.def += 13;
                                values.atk += 3;
                                values.fullness -= 20;
                                values.tired += 40;
                                values.energy -= 20;
                                values.exp += 20;
                                Console.WriteLine("Defence Increased by 13 and Attack Increased by 3");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose again");
                            break;
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
                            if (values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 5)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.spd += 4;
                                values.intel -= 1;
                                values.fullness -= 5;
                                values.tired += 10;
                                values.energy -= 5;
                                values.exp += 5;
                                Console.WriteLine("Speed Increased by 4 and Intellagence Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 10)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.spd += 7;
                                values.fullness -= 10;
                                values.tired += 20;
                                values.energy -= 10;
                                values.exp += 10;
                                Console.WriteLine("Speed Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 20)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.spd += 13;
                                values.intel += 3;
                                values.fullness -= 20;
                                values.tired += 40;
                                values.energy -= 20;
                                values.exp += 20;
                                Console.WriteLine("Speed Increased by 13 and Intellagence Increased by 3");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose again");
                            break;

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
                            if (values.energy < 5)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 5)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.intel += 4;
                                values.spd -= 1;
                                values.fullness -= 5;
                                values.tired += 10;
                                values.energy -= 5;
                                values.exp += 5;
                                Console.WriteLine("Intellagence Increased by 4 and Speed Decreased by 1");
                            }
                            break;
                        case "2":
                            //start 1 hour timer
                            if (values.energy < 10)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 10)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.intel += 7;
                                values.fullness -= 10;
                                values.tired += 20;
                                values.energy -= 10;
                                values.exp += 10;
                                Console.WriteLine("Intellagence Increased by 7");
                            }
                            break;
                        case "3":
                            //start 2 hour timer
                            if (values.energy < 20)
                            {
                                Console.WriteLine("Not Enough Energy!");

                            }
                            else if (values.fullness < 20)
                            {
                                Console.WriteLine("Im too hungry!");
                            }
                            else
                            {
                                values.intel += 13;
                                values.spd += 3;
                                values.fullness -= 20;
                                values.tired += 40;
                                values.energy -= 20;
                                values.exp += 20;
                                Console.WriteLine("Intellagence Increased by 13 and Speed Increased by 3");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose again");
                            break;

                    }
                    break;

                default:
                    Train(data, values);
                    break;


            }
  

            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();


        }

        static void Items(Values data, Values values)
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
                            Item.Nugget(values);
                            break;
                        case "2":
                            Item.Meat(values);
                            break;
                        case "3":
                            Item.LargeMeat(values);
                            break;
                        case "4":
                            Item.Sirloin(values);
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
                            Item.Pill(values);
                            break;
                        case "2":
                            Item.KillPill(values);
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

        static void Stats(Values data, Values values)
            {
                Console.Clear();
                Console.WriteLine("Stats");

                Console.WriteLine($"UserName: {values.userName}");
                Console.WriteLine($"DigiName: {values.digiName}");
                Console.WriteLine($"\nDigi: {values.digi}  \nAttack: {values.atk}  Defense: {values.def}  \n\nIntellagence: {values.intel}  Speed: {values.spd}" +
                    $"\n\nType: {values.type}  Attribute: {values.attribute}  Species: {values.species}  Personality: {values.per} " +
                    $"\n\nSickness: {values.sick}  Experiance: {values.exp}  Mood: {values.mood}" +
                    $"\n\nTired: {values.tired}  Sleep: {values.sleep}  Hunger: {values.fullness}  Poop: {values.poop}  Age: {values.age}");

                Console.WriteLine("\nPress Enter to return");
                Console.ReadLine();

        }

        public static void SaveData(Values data, string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(stream, data);
            }
        }

        public static Values LoadData(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
                Values data = (Values)formatter.Deserialize(stream);
                return data;
            }
        }
    }
}
    
  
