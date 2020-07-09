using System;

namespace BT_lop_fan
{
    public class Fan
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;

        private int speed;
        private bool on;
        private double radius;
        private string color;
        public Fan(int speed = 1, double radius = 5, string color = "Blue", bool on = false)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(int newSpeedFan)
        {
            speed = newSpeedFan;
        }
        public bool GetStatus()
        {
            return on;
        }
        public void SetStatus(bool newStatus)
        {
            on = newStatus;
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
        public void SetColor(string newColor)
        {
            color = newColor;
        }
        public string PrintToString()
        {
            string strSpeed;
            if (GetStatus() == true)
            {
                switch (GetSpeed())
                {
                    case 1:
                        strSpeed = "SLOW";
                        break;
                    case 2:
                        strSpeed = "MEDIUM";
                        break;
                    case 3:
                        strSpeed = "FAST";
                        break;
                    default:
                        strSpeed = "NO CHOICE!";
                        break;
                }
                return "Speed: " + strSpeed + " ,Color: " + GetColor() + " ,Radius: " + GetRadius().ToString() + " ,Fan is on";
            }
            else
            {
                return "Color: " + GetColor() + " ,Radius: " + GetRadius().ToString() + " ,Fan is off";
            }
        }
    }
}