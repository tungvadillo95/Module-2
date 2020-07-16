using System;

namespace TriangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleClassifier triangle = new TriangleClassifier();
            string result = triangle.TriangularClassification(2, 2, 5);
            Console.WriteLine(result);
        }
    }
}
