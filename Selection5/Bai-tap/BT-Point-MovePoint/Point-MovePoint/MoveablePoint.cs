using System;
using System.Collections.Generic;
using System.Text;

namespace Point_MovePoint
{
    public class MoveablePoint : Point
    {
        public float xSpeed = 0.0f;
        public float ySpeed = 0.0f;
        public MoveablePoint() { }
        public MoveablePoint(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public MoveablePoint(float xSpeed, float ySpeed,float x,float y):base(x,y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public float GetXSpeed()
        {
            return xSpeed;
        }
        public void SetXSpeed(float newXSpeed)
        {
            xSpeed = newXSpeed;
        }
        public float GetYSpeed()
        {
            return ySpeed;
        }
        public void SetYSpeed(float newYSpeed)
        {
            ySpeed = newYSpeed;
        }
        public void SetXYSpeed(float newXSpeed,float newYSpeed)
        {
            xSpeed = newXSpeed;
            ySpeed = newYSpeed;
        }
        public float[] GetSpeed()
        {
            float[] arr = { xSpeed, ySpeed };
            return arr;
        }
        public override string ToString()
        {
            return base.ToString()
            + "Point has xSpeed = "
            + GetXSpeed()
            + " and ySpeed = "
            + GetYSpeed();
           
        }
        public MoveablePoint Move() 
        {
            x += xSpeed;
            y += ySpeed;
            return this;
        }
    }
}
