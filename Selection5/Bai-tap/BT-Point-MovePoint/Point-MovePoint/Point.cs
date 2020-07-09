using System;
using System.Collections.Generic;
using System.Text;

namespace Point_MovePoint
{
    public class Point
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public Point()
        {

        }
        public Point(float x, float y)
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
            x = newY;
        }
        public void SetXY(float newX,float newY)
        {
            x = newX;
            y = newY;
        }
        public float[] GetXY()
        {
            float[] arr = { x, y };
            return arr;
        }
        public override string ToString()
        {
            return "Point 2D with X = "
                + GetX()
                + " and Y = "
                + GetY()
                +"\n";
        }
    }
}
