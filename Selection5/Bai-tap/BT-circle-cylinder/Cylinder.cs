using System;
namespace BT_circle_cylinder
{
    public class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double height)
        {
            this.height = height;
        }
        public Cylinder(double height, double radius, string color) : base(radius, color)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double newHeight)
        {
            height = newHeight;
        }
        public double GetVolume()
        {
            return GetArea() * height;
        }
        public override string ToString()
        {
            return "A Cylinder height "
            + GetHeight()
            + ", which is a subclass of "
            + base.ToString();
        }
    }
}