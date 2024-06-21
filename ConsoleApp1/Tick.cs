using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFrankAlbert
{
    internal class Tick : Bug
    {
        public Tick(string name = "Tick", bool hasLegs = true, bool hasWings = false, bool doesBite = true, bool doesSting = false) : base(name, hasLegs, hasWings, doesBite, doesSting)
        {
            name = Name;
            hasLegs = HasLegs;
            hasWings = HasWings;
            doesBite = DoesBite;
            doesSting = DoesSting;
        }
    }
}
