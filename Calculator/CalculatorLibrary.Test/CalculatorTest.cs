using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLibrary.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double num1 = 1;
            double num2 = 2;
            Calculator calculator = new Calculator();
            //Act
            var result = calculator.DoOperation(num1, num2,"a");
            //Assert
            var expected = 3;
            Assert.AreEqual(expected, result);
        }
    }
}
