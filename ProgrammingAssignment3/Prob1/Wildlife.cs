using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Wildlife : Animal
    {
        // abstract method 1 (animal base class)
        public override string Eat()
        {
            return "Go hunting!";
        }
        // abstract method 2 (animal base class)
        public override string Sleep()
        {
            return "Time to sleep - go to your habitat";
        }

    }
}
