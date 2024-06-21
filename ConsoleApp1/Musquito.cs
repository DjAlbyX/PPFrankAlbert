using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFrankAlbert
{
    internal class Musquito : Bug
    {
        public Musquito(string name = "Musquito", bool hasLegs = true, bool hasWings = true, bool doesBite = false, bool doesSting = true) : base(name, hasLegs, hasWings, doesBite, doesSting)
        {
            name = Name;
            hasLegs = HasLegs;
            hasWings = HasWings;
            doesBite = doesSting;
        }
    }
}
