using System;

namespace BT_lop_fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, 10, "Yellow", true);
            Console.WriteLine("Fan 1: " + fan1.PrintToString());
            Fan fan2 = new Fan(2, 5, "Blue", false);
            Console.WriteLine("Fan 2: " + fan2.PrintToString());
        }
    }
}
