using System;

namespace BT_phuong_trinh_bac_2
{
    public class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation() { }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SetA(double a)
        {
            this.a = a;
        }
        public double GetA()
        {
            return a;
        }

        public void SetB(double b)
        {
            this.b = b;
        }
        public double GetB()
        {
            return b;
        }
        public void SetC(double c)
        {
            this.c = c;
        }
        public double GetC()
        {
            return c;
        }

        public double GetDiscriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }

        public double GetRoot1(double a, double b, double delta)
        {
            var r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            return r1;
        }

        public double GetRoot2(double a, double b, double delta)
        {
            var r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return r2;
        }
    }
}