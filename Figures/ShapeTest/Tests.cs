using System;
using NUnit.Framework;
using Figures;

namespace ShapeTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleTest()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.539,circle.getArea(),0.005);
            circle = new Circle(0);
            Assert.AreEqual(0.0f,circle.getArea());
        }

        [Test]
        public void TriangleTest()
        {
            Triangle triangle = new Triangle(5,5,5);
            Assert.AreEqual(10.825f,triangle.getArea(),0.005);
            Assert.Throws<Exception>(() => triangle = new Triangle(5, 5, 0));
            triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());

        }
    }
}