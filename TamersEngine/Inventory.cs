using System;
using TamersEngine;
using Value;
using Digis;

namespace Inventory
{
    class Item
    {
        public static void Nugget(Values values)
        {
            values.fullness += 3;
            values.poop += 3;
        }
        public static void Meat(Values values)
        {
            values.fullness += 5;
            values.poop += 5;
        }
        public static void LargeMeat(Values values)
        {
            values.fullness += 15;
            values.poop += 15;
        }
        public static void Sirloin(Values values)
        {
            values.fullness += 35;
            values.poop += 35;
        }
        public static void Pill(Values values)
        {
            values.energy += 20;
            values.sick += 15;
        }
        public static void Vaccine(Values values)
        {
            values.sick += 25;
        }
        
    }
}