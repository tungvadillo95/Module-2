using System;

namespace Interface_Colorable
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes= new Shape[4];
            shapes[0] = new Circle(2, "red", true);
            shapes[1] = new Rectangle(3, 4, "yellow", false);
            shapes[2] = new Square(5, "orange", true);
            shapes[3] = new Square(6, "blue", false);
            foreach(var shape in shapes)
            {
                Console.Write($"Area shape: {shape.GetArea()}\t" );
                if(shape is IColorable)
                {
                    IColorable icolorable = (Square)shape;
                    icolorable.HowToColor();
                }
                else
                {
                    Console.Write("There is no coloring!.\n");
                }
            }
        }
    }
}
