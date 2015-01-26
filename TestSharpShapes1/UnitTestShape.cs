using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpShapes;
using System.Drawing;

namespace TestSharpShapes1
{
    public class myShape : Shape
    {

    }
    [TestClass]
    public class UnitTestShape
    {
        [TestMethod]
        public void TestSettingBorderColor()
        {
            Shape shape = new myShape();
            shape.BorderColor = Color.AliceBlue;
            Assert.AreEqual(Color.AliceBlue, shape.BorderColor);
        }
    }
}
