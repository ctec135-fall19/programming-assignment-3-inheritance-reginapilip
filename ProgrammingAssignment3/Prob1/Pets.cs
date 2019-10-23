using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Pets : Animal
    {
        // abstract method 1 (from Animal base class)
        public override string Eat()
        {
            return "Go find your food bowl and eat!";
        }
        // abstract method 2 (from Animal base class)
        public override string Sleep()
        {
            return "Time to sleep - go to your bed.";
        }
    }
}
