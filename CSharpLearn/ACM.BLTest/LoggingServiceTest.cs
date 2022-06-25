using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WrtieToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer()
            {
                EmailAddress ="Fbaggins@hobbiton.me"
            };
            changedItems.Add(customer);

            var product = new Product()
            {
                ProductName = "Milkers"
            };
            changedItems.Add(product);

            LoggigService.WriteToFile(changedItems);

        }
    }
}
