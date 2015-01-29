using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpShapes;

namespace TestSharpShapes1
{
    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(5, trapezoid.Base1);
            Assert.AreEqual(8, trapezoid.Base2);
            Assert.AreEqual(2, trapezoid.Height);
            //Assert.AreEqual(60, trapezoid AcuteAngle)
            //Assert.AreEqual(120, trapezoid ObtuseAngle)
        }

        //[TestMethod]
        //public void TestTrapezoidConstructorCalculateAngles1()
        //{
        //    Trapezoid trapezoid = new Trapezoid(5, 8, 2);
        //    Assert.AreEqual(60, trapezoid AcuteAngle);
        //    Assert.AreEqual(120, trapezoid ObtuseAngle);
        //}

        //[TestMethod]
        //public void TestTrapezoidConstructorCalculateAngles2()
        //{
        //    Trapezoid trapezoid = new Trapezoid(20, 15, 2);
        //    Assert.AreEqual(33.69, trapezoid AcuteAngle);
        //    Assert.AreEqual(146.31, trapezoid ObtuseAngle);
        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksBase1()
        {
            Trapezoid trapezoid = new Trapezoid(0, 8, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksBase1Positivity()
        {
            Trapezoid trapezoid = new Trapezoid(-1, 8, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksBase2()
        {
            Trapezoid trapezoid = new Trapezoid(5, 0, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksBase2Positivity()
        {
            Trapezoid trapezoid = new Trapezoid(5, -1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksHeight()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksHeightPositivity()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, -1);
        }

        [TestMethod]
        public void TestScaleTrapezoid200Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(200);
            Assert.AreEqual(10, trapezoid.Base1);
            Assert.AreEqual(16, trapezoid.Base2);
            Assert.AreEqual(4, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid150Percent()
        {
            Trapezoid trapezoid = new Trapezoid(8, 12, 3);
            trapezoid.Scale(150);
            Assert.AreEqual(12, trapezoid.Base1);
            Assert.AreEqual(18, trapezoid.Base2);
            Assert.AreEqual((decimal)4.5, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid100Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(100);
            Assert.AreEqual(5, trapezoid.Base1);
            Assert.AreEqual(8, trapezoid.Base2);
            Assert.AreEqual(2, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid37Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(37);
            Assert.AreEqual((decimal)1.85, trapezoid.Base1);
            Assert.AreEqual((decimal)2.96, trapezoid.Base2);
            Assert.AreEqual((decimal).74, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleRectangleUpAndDown()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(50);
            trapezoid.Scale(200);
            Assert.AreEqual(5, trapezoid.Base1);
            Assert.AreEqual(8, trapezoid.Base2);
            Assert.AreEqual(2, trapezoid.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleTrapezoidTo0Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleTrapezoidToNegativePercent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(-5);
        }

        [TestMethod]
        public void TestSidesCount()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(4, trapezoid.SidesCount);
        }

        [TestMethod]
        public void TestTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual((decimal)13, trapezoid.Area());
        }

        [TestMethod]
        public void TestBiggerTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(10, 16, 4);
            Assert.AreEqual((decimal)52, trapezoid.Area());
        }

        [TestMethod]
        public void TestTrapezoidPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual((decimal)16.61, trapezoid.Perimeter());
        }

        [TestMethod]
        public void TestBiggerTrapezoidPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(10, 16, 4);
            Assert.AreEqual((decimal)33.22, trapezoid.Perimeter());
        }

        [TestMethod]
        public void TestDefaultColors()
        {
            Trapezoid shape = new Trapezoid(5, 8, 2);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
        }
    }
}
