using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Shape
            Shape shape = new Shape();
            Console.WriteLine(shape);

            shape = new Shape("blue", false);
            Console.WriteLine(shape);
            //Test Triangle
            Triangle triangle = new Triangle();
            Console.WriteLine(triangle);

            triangle = new Triangle(4,5,6); // Tổng hai cạnh bất kỳ phải luôn lớn hơn cạnh còn lại !!!
            Console.WriteLine(triangle);

            triangle = new Triangle(5, 6, 7, "yellow", false);
            Console.WriteLine(triangle);
        }
    }
}
