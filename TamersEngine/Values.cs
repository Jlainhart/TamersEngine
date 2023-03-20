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
        public string userName { get; set; }
        [DataMember]
        public string per { get; set; }
        [DataMember]
        public string digiName { get; set; }
        [DataMember]
        public bool digiDeath { get; set; }
        [DataMember]
        public int lvl { get; set; }
        [DataMember]
        public int hp { get; set; }
        [DataMember]
        public int minhp { get; set; }
        [DataMember]
        public int maxhp { get; set; }
        [DataMember]
        public int mp { get; set; }
        [DataMember]
        public int minmp { get; set; }
        [DataMember]
        public int maxmp { get; set; }
        [DataMember]
        public int atk { get; set; }
        [DataMember]
        public int def { get; set; }
        [DataMember]
        public int intel { get; set; }
        [DataMember]
        public int spd { get; set; }
        [DataMember]
        public int energy { get; set; }
        [DataMember]
        public int minenergy { get; set; }
        [DataMember]
        public int maxenergy { get; set; }
        [DataMember]
        public int sick { get; set; }
        [DataMember]
        public int minsick { get; set; }
        [DataMember]
        public int maxsick { get; set; }
        [DataMember]
        public int exp { get; set; }
        [DataMember]
        public int mood { get; set; }
        [DataMember]
        public int tired { get; set; }
        [DataMember]
        public int mintired { get; set; }
        [DataMember]
        public int maxtired { get; set; }
        [DataMember]
        public int sleep { get; set; }
        [DataMember]
        public int fullness { get; set; }
        [DataMember]
        public int minfullness { get; set; }
        [DataMember]
        public int maxfullness { get; set; }
        [DataMember]
        public int poop { get; set; }
        [DataMember]
        public int minpoop { get; set; }
        [DataMember]
        public int maxpoop { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public int minAge { get; set; }
        [DataMember]
        public int maxAge { get; set; }
        [DataMember]
        public string digi { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string attribute { get; set; }
        [DataMember]
        public string species { get; set; }
        [DataMember]
        public string mon { get; set; }
        [DataMember]
        public DateTime timeStampBorn { get; set; }
        public string test = "savetest";
        //public string[] badWords = { "ass", "butt" };


    }
}
