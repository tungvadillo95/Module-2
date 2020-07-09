using System;
namespace BT_access_modifier
{
    class Circle
    {
        private double radius;
        private string color;
        // public Circle() { }
        public Circle(double radius = 1.0, string color = "red")
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double newradius)
        {
            radius = newradius;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string newcolor)
        {
            color = newcolor;
        }
        public double GetArea()
        {
            return radius * radius * 3.14;
        }
    }
}