using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt1._0;

namespace Project1._0.UnitTests
{
    [TestClass]
    public class CrossSectionCharacteristicUnitTest
    {
        [TestMethod]
        public void AreaReinforcementUnitTest()
        {
            //Arrange
            var crosssection = new CrossSectionCharacteristic();
            //Act
            crosssection.FiAs1 = 18;
            crosssection.CountAs1 = 4;
            crosssection.Calculate();
            var result = Math.Round(crosssection.AreaAs1, 2);
            //Assert
            Assert.AreEqual(1017.88, result);
            
        }

        [TestMethod]
        public void AreaConcreteUnitTest()
        {
            //Arrange
            var crosssection = new CrossSectionCharacteristic();
            //Act
            crosssection.FiAs1 = 18;
            crosssection.CountAs1 = 4;
            crosssection.Width = 0.3;
            crosssection.Height = 0.5;
            crosssection.Calculate();
            var result = Math.Round(crosssection.AreaConcrete, 5);
            //Assert
            Assert.AreEqual(0.14898, result);

        }
    }
}
