using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Colorable
{
    public class Circle : Shape

    {
        private double radius = 1.0;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.Round(radius * radius * Math.PI,2);
        }
        public double GetPerimeter()
        {
            return Math.Round(2 * radius * Math.PI,2);
        }
        public override String ToString()
        {
            return "A Circle with radius = "

                    + GetRadius()

                    + ", which is a subclass of "

                    + base.ToString();
        }

    }
}
