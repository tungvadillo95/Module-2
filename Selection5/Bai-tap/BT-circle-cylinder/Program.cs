using System;

namespace BT_circle_cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(5, "blue");
            Console.WriteLine(circle);

            Cylinder cylinder = new Cylinder();
            Console.WriteLine(cylinder);

            cylinder = new Cylinder(10);
            Console.WriteLine(cylinder);

            cylinder = new Cylinder(10, 4, "green");
            Console.WriteLine(cylinder);
        }
    }
}
