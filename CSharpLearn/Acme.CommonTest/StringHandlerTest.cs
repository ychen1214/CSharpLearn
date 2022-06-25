using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewDriver";
            var expected = "Sonic Screw Driver";
            

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screw Driver";
            var expected = "Sonic Screw Driver";
            
            // Act 
            var actual = source.InsertSpaces();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
