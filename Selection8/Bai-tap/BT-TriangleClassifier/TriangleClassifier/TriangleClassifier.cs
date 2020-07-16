using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleClass
{
    public class TriangleClassifier
    {
        public string TriangularClassification(int side1, int side2, int side3)
        {
            bool isTriangle = (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1);
            int[] arr = new int[3] { side1, side2, side3 };
            if (side1 == side2 && side1 == side3 && isTriangle)
            {
                return "Equilateral triangle";
            }
            if ((side1 == side2 || side1 == side3 || side2 == side3) && isTriangle)
            {
                return "Isosceles triangle";
            }
            if (IsRightTriangle(arr) && isTriangle)
            {
                return "Right triangle";
            }
            if (isTriangle)
            {
                return "Regular triangle";
            }
            return "Is not a right triangle";
        }
        public static int MaxSide(int[] arr,out int index)
        {
            int pos=0;
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    pos = i;
                }
            }
            index = pos;
            return max;
        }
        public static bool IsRightTriangle(int[] arr)
        {
            int max = MaxSide(arr, out int index);
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    total += arr[i] * arr[i];
                }
            }
            if(arr[index]* arr[index] == total)
            {
                return true;
            }
            return false;
        }

    }
}
