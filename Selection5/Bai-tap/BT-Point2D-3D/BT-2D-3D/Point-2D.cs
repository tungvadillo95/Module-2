using System;
using System.Collections.Generic;
using System.Text;

namespace BT_2D_3D
{
     public class Point2D
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public Point2D()
        {

        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return x;
        }
        public void SetX(float newX)
        {
            x = newX;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float newY)
        {
            y = newY;
        }
        public float[] GetXY()
        {
            float[] arr = { x, y };
            return arr;
        }
        public void SetXY(float newX ,float newY)
        {
            x = newX;
            y = newY;
        }
        public override string ToString()
        {
            return "A Point 2D with X = "
                + GetX()
                + " and Y = "
                + GetY();    
        }
    }
}
