using System;
using System.Collections;
using System.Linq;

namespace Linq_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add(new Staff { ID = 1, Name = "Nam", Age = 24 });
            myAL.Add(new Staff { ID = 2, Name = "Kien", Age = 21 });
            myAL.Add(new Staff { ID = 3, Name = "Viet", Age = 21 });
            myAL.Add(new Staff { ID = 4, Name = "Hang", Age = 23 });
            myAL.Add(new Staff { ID = 5, Name = "Tien", Age = 24 });
            foreach (Staff theElement in myAL)
            {
                Console.WriteLine($"{theElement.ID}\t{theElement.Name}\t{theElement.Age}");
            }
            Console.WriteLine("Use LINQ(sort people under 24 years by name)......");
            var linq = from Staff theElement in myAL
                       where theElement.Age < 24
                       orderby theElement.Name
                       select theElement;
            foreach(var theElement in linq)
            {
                Console.WriteLine($"{theElement.ID}\t{theElement.Name}\t{theElement.Age}");
            }
        }
    }
}
