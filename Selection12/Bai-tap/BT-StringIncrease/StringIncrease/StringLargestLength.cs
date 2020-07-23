using System;
using System.Collections.Generic;
using System.Text;

namespace StringIncrease
{
    class StringLargestLength
    {
        public int First { get; set; }
        public int Last { get; set; }
        public int CountLength()
        {
            return Last - First + 1;
        }
    }
}
