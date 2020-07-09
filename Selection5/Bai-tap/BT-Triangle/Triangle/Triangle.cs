using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
   public class Triangle : Shape
    {
        public double side1 = 1.0;
        public double side2 = 1.0;
        public double side3 = 1.0;
        public Triangle()
        {

        }
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public Triangle(double side1, double side2, double side3, String color, bool filled):base(color,filled)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double GetSide1()
        {
            return side1;
        }
        public void SetSide(double newSide1)
        {
            side1 = newSide1;
        }
        public double GetSide2()
        {
            return side2;
        }
        public void SetSide2(double newSide2)
        {
            side2 = newSide2;
        }
        public double GetSide3()
        {
            return side3;
        }
        public void SetSide3(double newSide3)
        {
            side3 = newSide3;
        }
        public double GetPerimeter()
        {
            return side1 + side2 + side3;
        }
        public double GetArea()
        {
            return  Math.Round(Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - side1) * (GetPerimeter() / 2 - side2) * (GetPerimeter() / 2 - side3)),2);
        }
        public override string ToString()
        {
            return $"The triangle has sides a = {GetSide1()}, b = {GetSide2()} and {GetSide3()}. Perimeter = {GetPerimeter()}. Area = {GetArea()}. "
                + base.ToString();
        }
    }
}
