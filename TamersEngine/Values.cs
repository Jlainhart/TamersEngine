﻿using System;
using TamersStats;
using TamersEngine;
using System.IO;
using System.Xml.Serialization;

namespace Value
{
[Serializable]
    public class Values
    {
        //int and bool variables save as 0 and false
        //strings do not save 
        [XmlElement]
        public string userName { get; set; }
        [XmlElement]
        public string per { get; set; }
        [XmlElement]
        public string digiName { get; set; }
        public bool digiDeath { get; set; }
        public int lvl { get; set; }
        public int hp { get; set; }
        public int minhp { get; set; }
        public int maxhp { get; set; }
        public int mp { get; set; }
        public int minmp { get; set; }
        public int maxmp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int intel { get; set; }
        public int spd { get; set; }
        public int energy { get; set; }
        public int minenergy { get; set; }
        public int maxenergy { get; set; }
        public int sick { get; set; }
        public int minsick { get; set; }
        public int maxsick { get; set; }
        public int exp { get; set; }
        public int mood { get; set; }
        public int tired { get; set; }
        public int mintired { get; set; }
        public int maxtired { get; set; }
        public int sleep { get; set; }
        public int fullness { get; set; }
        public int minfullness { get; set; }
        public int maxfullness { get; set; }
        public int poop { get; set; }
        public int minpoop { get; set; }
        public int maxpoop { get; set; }
        public int age { get; set; }
        public int minAge { get; set; }
        public int maxAge { get; set; }
        [XmlElement]
        public string digi { get; set; }
        [XmlElement]
        public string type { get; set; }
        [XmlElement]
        public string attribute { get; set; }
        [XmlElement]
        public string species { get; set; }
        [XmlElement]
        public string mon { get; set; }
        public DateTime timeStampBorn { get; set; }

    }
    public static class ValueManager
    {
        public static void SaveData(Values values)
        {
                var serializer = new XmlSerializer(typeof(Values));
                using (var writer = new StreamWriter("values.xml"))
                {
                    serializer.Serialize(writer, values);
                }
        }

        public static Values LoadData()
        {
            Values loadedValues;
            var serializer = new XmlSerializer(typeof(Values));
            using (var reader = new StreamReader("values.xml"))
            {
                loadedValues = (Values)serializer.Deserialize(reader);
            }
            return loadedValues;
        }
    }
}
