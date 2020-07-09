using System;
namespace BT_circle_cylinder
{
    public class Circle
    {
        private double radius = 1.0;
        private string color = "back";
        public Circle()
        {

        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }
        public string GetColor()
        {
            return color;
        }
        public void GetColor(string newColor)
        {
            color = newColor;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return "A Circle with color of "
            + GetColor()
            + " and "
            + "Radius is " + GetRadius();
        }

    }
}