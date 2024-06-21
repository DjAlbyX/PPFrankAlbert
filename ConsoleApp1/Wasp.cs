using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFrankAlbert
{
    class Wasp : Bug
    {

        public Wasp(string name = "Wasp", bool hasLegs = true, bool hasWings = true, bool doesBite = true, bool doesSting = true) : base(name, hasLegs, hasWings, doesBite, doesSting)
        {
            name = Name;
            hasLegs = HasLegs;
            hasWings = HasWings;
            doesBite = DoesBite;
            doesSting = DoesSting;

        }


    }
}
