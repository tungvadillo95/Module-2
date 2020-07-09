using System;

namespace BT_2D_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            var p2d = new Point2D();
            Console.WriteLine(p2d);

           p2d = new Point2D(3,4);
            Console.WriteLine(p2d);

            var p3d = new Point3D();
            Console.WriteLine(p3d);

            p3d = new Point3D(4, 2, 5);
            Console.WriteLine(p3d);
        }
    }
}
