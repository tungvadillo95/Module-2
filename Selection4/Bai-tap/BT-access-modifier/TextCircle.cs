using System;

namespace BT_access_modifier
{
    class TextCircle
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            double radius;
            string color;
            Console.WriteLine("Generate Cricle ");
            Console.Write("Enter radius cricle: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter color cricle: ");
            color = Console.ReadLine();
            Console.Write("The Cricle:\t");
            Console.Write("Radius " + circle.GetRadius() + "\t");
            Console.Write(" Color  " + circle.GetColor() + "\t");
            Console.Write(" Area  " + circle.GetArea() + "\t");
        }
    }
}
