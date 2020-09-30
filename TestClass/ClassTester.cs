using System;
using Assignment1_UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class ClassTester
    {
        private Bicycle _bicycle;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            _bicycle = new Bicycle(1, "Red", 2000, 6);
        }

        [TestMethod]
        public void BicycleColorTest()
        {
            Assert.AreEqual("Red", _bicycle.Color);

            Assert.ThrowsException<ArgumentException>(() => _bicycle.Color = "");
        }

        [TestMethod]
        public void BicyclePriceTest()
        {
            Assert.AreEqual(2000, _bicycle.Price);

            Assert.ThrowsException<ArgumentException>(() => _bicycle.Price = 0);
        }

        [TestMethod]
        public void BicycleGearTest()
        {
            Assert.AreEqual(6, _bicycle.Gear);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bicycle.Gear = 35);
        }
    }
}
