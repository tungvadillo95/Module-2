using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResizeable
{
    public class Rectangle : Shape,Resizeable

    {
        private double width = 1.0;

        private double length = 1.0;

        public Rectangle()
        {

        }
        public Rectangle(double width, double length)

        {

            this.width = width;

            this.length = length;

        }
        public Rectangle(double width, double length, String color, bool filled) : base(color, filled)

        {

            this.width = width;

            this.length = length;

        }
        public double GetWidth()

        {

            return width;

        }
        public virtual void SetWidth(double width)

        {

            this.width = width;

        }
        public double GetLength()

        {

            return length;

        }
        public virtual void SetLength(double length)

        {

            this.length = length;

        }
        public double GetArea()

        {

            return Math.Round(width *length,2);

        }
        public double GetPerimeter()

        {

            return Math.Round(2 * (width + this.length),2);

        }
        public override String ToString()

        {

            return "A Rectangle with width="

                    + GetWidth()

                    + " and length="

                    + GetLength()

                    + ", "

                    + base.ToString();

        }

        public virtual void Resize(double percent)
        {
            width += (width * percent / 100);
            length += (length * percent / 100);
        }
    }
}
