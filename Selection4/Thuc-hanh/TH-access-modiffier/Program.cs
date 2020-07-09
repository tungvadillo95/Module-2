using System;

namespace TH_access_modiffier
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicLib.Class1 pc = new PublicLib.Class1();
            Console.WriteLine("Total a + b : " + pc.Sum(1, 2));

            InternalLib.Class1 ic = new InternalLib.Class1();
            Console.WriteLine("Total a + b : " + ic.Sum(1, 2));
        }
    }
}
