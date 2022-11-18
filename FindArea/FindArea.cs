using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinBoxFindArea.Shapes;
using System;

namespace FindArea
{
    [TestClass]
    public class FindArea
    {
        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-4));
        }

        [TestMethod]
        public void CircleGetAreaTest()
        {
            Circle circle = new Circle(7);

            Assert.AreEqual(153.93804002589985, circle.Area);
        }

        [TestMethod]
        public void TriangleNegativeSideTest()
        {
            //Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 2, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, -2, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, -3));
        }

        [TestMethod]
        public void TriangleGetAreaTest()
        {
            Triangle triangle = new Triangle(6, 4, 5);

            Assert.AreEqual(9.921567416492215, triangle.Area);
        }

        [TestMethod]
        public void TriangleIsRectengular()
        {
            Triangle triangle = new Triangle(26, 10, 24);

            Assert.AreEqual(true, triangle.IsRectengular());
        }

        [TestMethod]
        public void TriangleIsNotRectengular()
        {
            Triangle triangle = new Triangle(25, 10, 24);

            Assert.AreEqual(false, triangle.IsRectengular());
        }
    }
}
