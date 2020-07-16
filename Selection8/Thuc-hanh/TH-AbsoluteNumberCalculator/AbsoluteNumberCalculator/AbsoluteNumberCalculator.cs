using System;
using System.Collections.Generic;
using System.Text;

namespace AbsoluteCalculator.Service
{
    public class AbsoluteNumberCalculator
    {
        public int FindAbsolute(int number)
        {
            if (number < 0)
                return -number;
            return number;
        }
    }
}
