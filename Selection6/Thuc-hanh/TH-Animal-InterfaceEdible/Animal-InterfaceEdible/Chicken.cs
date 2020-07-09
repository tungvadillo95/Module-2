using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_InterfaceEdible
{
    public class Chicken : Animal, IEdible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }

}
