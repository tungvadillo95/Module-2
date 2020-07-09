using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResizeable
{
    public class Square : Rectangle , Resizeable
    {
        public Square()
        {
        }
        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {
        }
        public double getSide()
        {
            return GetWidth();
        }

        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }
        public override String ToString()
        {
            return "A Square with side="
                    + getSide()
                    + ", which is a subclass of "
                    + base.ToString();
        }
        public override void Resize(double percent)
        {
           SetSide(getSide()+getSide()*percent/100);
        }
    }
}
