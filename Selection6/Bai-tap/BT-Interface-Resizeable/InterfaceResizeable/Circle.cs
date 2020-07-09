using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResizeable
{
    public class Circle : Shape, Resizeable
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

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return  Math.Round(radius * radius * Math.PI,2);
        }

        public double getPerimeter()
        {
            return Math.Round(2 * radius * Math.PI,2);
        }

        public override string ToString()
        {
            return "A Circle with radius="
                    + getRadius()
                    + ", "
                    + base.ToString();
        }

        public void Resize(double percent)
        {
            radius += (radius * percent / 100);
        }
    }
}
