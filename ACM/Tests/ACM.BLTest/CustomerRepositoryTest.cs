﻿using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveNotValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                //EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreNotEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }


        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                //Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var updateCustomer = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "fbaggins@hobbiton.me",
                CustomerType = 1,
                HasChanges = true
            };

            // Act
            var actual = customerRepository.Save(updateCustomer);

            // Assert
            Assert.AreEqual(true, actual);
        }


        [TestMethod]
        public void SaveTestMissingLastName()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var updateCustomer = new Customer(1)
            {
                LastName = null,
                FirstName = "Frodo",
                EmailAddress = "fbaggins@hobbiton.me",
                CustomerType = 1,
                HasChanges = true
            };

            // Act
            var actual = customerRepository.Save(updateCustomer);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
