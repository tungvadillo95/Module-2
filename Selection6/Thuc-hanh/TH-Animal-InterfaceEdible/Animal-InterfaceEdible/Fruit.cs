using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_InterfaceEdible
{
    public abstract class Fruit : IEdible
    {
        public abstract string HowToEat();
    }
}
