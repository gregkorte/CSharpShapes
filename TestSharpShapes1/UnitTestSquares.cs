using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpShapes;

namespace TestSharpShapes1
{
    [TestClass]
    public class UnitTestSquares
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(40);
            Assert.AreEqual(40, square.Height);
            Assert.AreEqual(40, square.Width);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksLengthPositivity()
        {
            Square square = new Square(-1);
        }

        [TestMethod]
        public void TestScaleRectangle200Percent()
        {
            Square square = new Square(10);
            square.Scale(200);
            Assert.AreEqual(20, square.Height);
            Assert.AreEqual(20, square.Width);
        }

        [TestMethod]
        public void TestScaleRectangle150Percent()
        {
            Square square = new Square(10);
            square.Scale(150);
            Assert.AreEqual(15, square.Height);
            Assert.AreEqual(15, square.Width);
        }

        [TestMethod]
        public void TestScaleRectangle100Percent()
        {
            Square square = new Square(10);
            square.Scale(100);
            Assert.AreEqual(10, square.Height);
            Assert.AreEqual(10, square.Width);
        }

        [TestMethod]
        public void TestScaleRectangle37Percent()
        {
            Square square = new Square(10);
            square.Scale(37);
            Assert.AreEqual((decimal)3.7, square.Width);
            Assert.AreEqual((decimal)3.7, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquareTo0Percent()
        {
            Square square = new Square(10);
            square.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquareToNegativePercent()
        {
            Square square = new Square(10);
            square.Scale(-5);
        }

        [TestMethod]
        public void TestSidesCount()
        {
            Square square = new Square(10);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(10);
            Assert.AreEqual(100, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(15);
            Assert.AreEqual(225, square.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(10);
            Assert.AreEqual(40, square.Perimeter());
        }

        [TestMethod]
        public void TestBiggerSquarePerimeter()
        {
            Square square = new Square(100);
            Assert.AreEqual(400, square.Perimeter());
        }

        [TestMethod]
        public void TestDefaultColors()
        {
            Square shape = new Square(10);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
        }
    }
}
