using System;

namespace InterfaceResizeable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Circle
            var circle = new Circle(5, "blue", true);
            Console.WriteLine(circle);
            double x = Math.Round(100 * new Random().NextDouble(), 2);
            Console.WriteLine($"Percentage resize X = {x} %");
            Console.WriteLine($"Area before: {circle.getArea()}");
            circle.Resize(x);
            Console.WriteLine($"New radius = {circle.getRadius()}, Area new: {circle.getArea()}");

            //Test Rectangle
            var rectangle = new Rectangle(4, 5, "yellow", false);
            Console.WriteLine(rectangle);
            x = Math.Round(100 * new Random().NextDouble(), 2);
            Console.WriteLine($"Percentage resize X = {x} %");
            Console.WriteLine($"Area before: {rectangle.GetArea()}");
            rectangle.Resize(x);
            Console.WriteLine($"New width = {rectangle.GetWidth()} and length = {rectangle.GetLength()}, Area new: {rectangle.GetArea()}");

            //Test Square
            var squard = new Square(3, "orange", true);
            Console.WriteLine(squard);
            x = Math.Round(100 * new Random().NextDouble(), 2);
            Console.WriteLine($"Percentage resize X = {x} %");
            Console.WriteLine($"Area before: {squard.GetArea()}");
            squard.Resize(x);
            Console.WriteLine($"New side = {squard.getSide()}, Area new: {squard.GetArea()}");
        }
    }
}
