using System;

namespace RefactoringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            int heigth;
            double result;
            Console.Write("Enter the cylinder radius: ");
            radius = int.Parse(Console.ReadLine());
            Console.Write("Enter the cylinder height: ");
            heigth = int.Parse(Console.ReadLine());
            result = Math.Round(CylinderDemo.GetVolume(radius, heigth),3);
            Console.WriteLine($"Cylindrical volume = {result}");
        }
    }
}
