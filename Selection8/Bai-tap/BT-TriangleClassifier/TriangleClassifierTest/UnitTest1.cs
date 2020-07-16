using NUnit.Framework;
using TriangleClass;

namespace TriangleClassifierTest
{
    public class TriangleClassifierTest
    {
        private TriangleClassifier _triangleClassifier;
        [SetUp]
        public void Setup()
        {
            _triangleClassifier = new TriangleClassifier();
        }
        [Test]
        public void TriangleClassifierTest1()
        {
            int side1 = 6;
            int side2 = 8;
            int side3 = 10;
            string expected = "Right triangle";
            string result = _triangleClassifier.TriangularClassification(side1, side2, side3);
            Assert.IsTrue(expected==result);
        }
        [Test]
        public void TriangleClassifierTest2()
        {
            int side1 = 4;
            int side2 = 16;
            int side3 = 9;
            string expected = "Is not a right triangle";
            string result = _triangleClassifier.TriangularClassification(side1, side2, side3);
            Assert.IsTrue(expected == result);
        }
        [Test]
        public void TriangleClassifierTest3()
        {
            int side1 = 9;
            int side2 = 15;
            int side3 = 9;
            string expected = "Isosceles triangle";
            string result = _triangleClassifier.TriangularClassification(side1, side2, side3);
            Assert.IsTrue(expected == result);
        }
        [Test]
        public void TriangleClassifierTest4()
        {
            int side1 = 9;
            int side2 = 9;
            int side3 = 9;
            string expected = "Equilateral triangle";
            string result = _triangleClassifier.TriangularClassification(side1, side2, side3);
            Assert.IsTrue(expected == result);
        }
        [Test]
        public void TriangleClassifierTest5()
        {
            int side1 = 12;
            int side2 = 8;
            int side3 = 9;
            string expected = "Regular triangle";
            string result = _triangleClassifier.TriangularClassification(side1, side2, side3);
            Assert.IsTrue(expected == result);
        }
    }
}