using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryWithUnitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryWithUnitTest.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void DefaultCarTest()
        {
            Car c = new Car();

            Assert.AreEqual(20, c.Mileage);
            Assert.AreEqual("Green", c.Color);
        }

        [TestMethod()]
        public void OverloadedCarTest()
        {
            try
            {
                Car c = new Car(0, "Red");

                Assert.AreEqual(20, c.Mileage);
                Assert.AreEqual("Red", c.Color);
            } catch (LessThanZeroOrEqualToException) {
                // display error message
            }
        }
    }
}