using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersEngine;
using Value;
using Digis;

namespace Inventory
{
    class Item
    {
        public static void Nugget()
        {
            Values.fullness += 3;
            Values.poop += 3;
        }
        public static void Meat()
        {
            Values.fullness += 5;
            Values.poop += 5;
        }
        public static void LargeMeat()
        {
            Values.fullness += 15;
            Values.poop += 15;
        }
        public static void Sirloin()
        {
            Values.fullness += 35;
            Values.poop += 35;
        }
        public static void Pill()
        {
            Values.energy += 20;
            Values.sick += 15;
        }
        public static void KillPill()
        {
            Values.sick += 100;
        }
        
    }
}