using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
   public abstract class BaseDisc
    {
       
        public string Name { get; set; }
        public string Type { get; set; }
        public int Storage { get; set; }       
        protected BaseDisc(string name, string type, int storage)
        {
            Name = name;
            Type = type;
            Storage = storage;
           
        }

        public string DiskInfo()
        {
            string infoOutput = $"Disk Name: {Name}\nType of Disc: {Type}\n Max Capacity: {Storage}\n";
            return infoOutput;
        }

        
    }
}
