using System;

namespace Point_MovePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Test class Point*/

            Point point=new Point();
            Console.WriteLine(point);

            point = new Point(5, 5);
            Console.WriteLine(point);

            /*Test class MoveablePoint*/

            MoveablePoint movepoint = new MoveablePoint();
            Console.WriteLine(movepoint);
            movepoint.Move();
            Console.WriteLine($"Point current coordinates X = {movepoint.GetX()} and Y = {movepoint.GetY()}\n");

            movepoint = new MoveablePoint(2, 4);
            Console.WriteLine(movepoint);
            movepoint.Move();
            Console.WriteLine($"Point current coordinates X = {movepoint.GetX()} and Y = {movepoint.GetY()}\n");

            movepoint = new MoveablePoint(1, 2, 3, 4);
            Console.WriteLine(movepoint);
            movepoint.Move();
            Console.WriteLine($"Point current coordinates X = {movepoint.GetX()} and Y = {movepoint.GetY()}\n");
        }
    }
}
