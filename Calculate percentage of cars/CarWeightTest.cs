using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculate_percentage_of_cars
{
    [TestClass]
    public class CarWeightTest
    {
        [TestMethod]
        public void GetCarWeight()
        {
            // Arrange
            StarCars.CarsCalculator CW = new StarCars.CarsCalculator
            {
                Height = 1600,
                Width = 187600,
                Class = 'B'
            };

            // Act
            double actual = CW.GetCarWeight();
            double expected = 186950;

            // Assert
            Assert.AreEqual(expected , actual);
        }
    }
}
