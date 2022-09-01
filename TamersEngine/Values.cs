using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;
using TamersStats;
using TamersEngine;
using Inventory;
using Digis;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Value
{
[Serializable]
    public class Values
    {

        [DataMember]
        public static string userName { get; set; }
        [DataMember]
        public static string per { get; set; }
        [DataMember]
        public static string digiName { get; set; }
        [DataMember]
        public static bool digiDeath { get; set; }
        [DataMember]
        public static int lvl { get; set; }
        [DataMember]
        public static int hp { get; set; }
        [DataMember]
        public static int minhp { get; set; }
        [DataMember]
        public static int maxhp { get; set; }
        [DataMember]
        public static int mp { get; set; }
        [DataMember]
        public static int minmp { get; set; }
        [DataMember]
        public static int maxmp { get; set; }
        [DataMember]
        public static int atk { get; set; }
        [DataMember]
        public static int def { get; set; }
        [DataMember]
        public static int intel { get; set; }
        [DataMember]
        public static int spd { get; set; }
        [DataMember]
        public static int energy { get; set; }
        [DataMember]
        public static int minenergy { get; set; }
        [DataMember]
        public static int maxenergy { get; set; }
        [DataMember]
        public static int sick { get; set; }
        [DataMember]
        public static int minsick { get; set; }
        [DataMember]
        public static int maxsick { get; set; }
        [DataMember]
        public static int exp { get; set; }
        [DataMember]
        public static int mood { get; set; }
        [DataMember]
        public static int tired { get; set; }
        [DataMember]
        public static int mintired { get; set; }
        [DataMember]
        public static int maxtired { get; set; }
        [DataMember]
        public static int sleep { get; set; }
        [DataMember]
        public static int fullness { get; set; }
        [DataMember]
        public static int minfullness { get; set; }
        [DataMember]
        public static int maxfullness { get; set; }
        [DataMember]
        public static int poop { get; set; }
        [DataMember]
        public static int minpoop { get; set; }
        [DataMember]
        public static int maxpoop { get; set; }
        [DataMember]
        public static int age { get; set; }
        [DataMember]
        public static int minAge { get; set; }
        [DataMember]
        public static int maxAge { get; set; }
        [DataMember]
        public static string digi { get; set; }
        [DataMember]
        public static string type { get; set; }
        [DataMember]
        public static string attribute { get; set; }
        [DataMember]
        public static string species { get; set; }
        [DataMember]
        public static string mon { get; set; }
        [DataMember]
        public static DateTime timeStampBorn { get; set; }
        public string[] badWords = { "ass", "butt" };


    }
}
