using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpShapes;
using System.Drawing;

namespace TestSharpShapes1
{
    [TestClass]
    public class UnitTestShape
    {
        [TestMethod]
        public void TestSettingBorderColor()
        {
            Shape shape = new Shape();
            shape.BorderColor = Color.AliceBlue;
            Assert.AreEqual(Color.AliceBlue, shape.BorderColor);
        }
    }
}
