﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            _ = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;
            _ = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1;
            _ = new Customer
            {
                FirstName = "Rosie"
            };
            Customer.InstanceCount += 1;
            //-- Act 

            //-- Assert 
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggings@hotton.me"
            };
            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {                
                EmailAddress = "fbaggings@hotton.me"
            };
            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
