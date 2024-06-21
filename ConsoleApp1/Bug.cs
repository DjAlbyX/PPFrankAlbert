using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PPFrankAlbert
{
    internal class Bug
    {
        public string Name { get; private set; }
        public bool HasLegs { get; private set; }
        public bool HasWings { get; private set; }
        public bool DoesBite { get; private set; }
        public bool DoesSting { get; private set; }

        public Bug(string name, bool hasLegs, bool hasWings, bool doesBite, bool doesSting)
        {
            Name = name;
            HasLegs = hasLegs;
            HasWings = hasWings;
            DoesBite = doesBite;
            DoesSting = doesSting;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine("Has legs? " + (HasLegs ? "Yes" : "No"));
            Console.WriteLine("Has wings? " + (HasWings ? "Yes" : "No"));
            Console.WriteLine("Does bite? " + (DoesBite ? "Yes" : "No"));
            Console.WriteLine("Does sting? " + (DoesSting ? "Yes" : "No"));

        }

        
    }

}
