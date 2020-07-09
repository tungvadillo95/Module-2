using System;

namespace BT_phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Quadratic: ax2 + bx + c = 0");
            Console.WriteLine("Enter value a(a#0): ");
            a = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Enter value a(a#0): ");
                a = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter value b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value c: ");
            c = double.Parse(Console.ReadLine());
            QunadraticEquation quaquadratic = new QunadraticEquation(a, b, c);

            double denta = quaquadratic.GetDiscriminant();
            if (denta > 0)
            {
                Console.WriteLine("Quadratic equations have 2 solutions: ");
                Console.WriteLine("x1 = " + quaquadratic.GetRoot1() + "\t x2 = " + quaquadratic.GetRoot2());

            }
            else if (denta == 0)
            {
                Console.WriteLine("Quadratic equations have solutions x = " + quaquadratic.GetRoot1());
            }
            else
            {
                Console.WriteLine("The equation has no roots");
            }
        }

    }
    public class QunadraticEquation
    {
        private double a, b, c;
        public QunadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetA()
        {
            return a;
        }
        public double GetB()
        {
            return b;
        }
        public double GetC()
        {
            return c;
        }
        public double GetDiscriminant()
        {
            return b * b - 4 * a * c;
        }
        public double GetRoot1()
        {
            if (GetDiscriminant() >= 0)
            {
                return (-b + Math.Pow(GetDiscriminant(), 0.5)) / 2;
            }
            else
            {
                return 0;
            }
        }
        public double GetRoot2()
        {
            if (GetDiscriminant() >= 0)
            {
                return (-b - Math.Pow(GetDiscriminant(), 0.5)) / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
