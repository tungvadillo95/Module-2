using System;
using System.Collections.Generic;
using System.Text;

namespace BT_2D_3D
{
    public class Point3D: Point2D
    {
        private float z = 0.0f;
        public Point3D() 
        { 

        }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float newZ)
        {
            z = newZ;
        }
        public void SetXYZ(float newX, float newY, float newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }
        public float[] GetXYZ()
        {
            float[] arr = { x, y, z };
            return arr;
        }
        public override string ToString()
        {
            return "Point 3D with x = "
                +GetX()
                +"\ty = "
                +GetY()
                +"\t z = "
                +GetZ()
                +", which is a subclass of "
                + base.ToString();
        }
    }
}
