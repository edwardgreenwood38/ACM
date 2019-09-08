using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = StringHandler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpacesTestEmptySource()
        {
            // Arrange
            string source = "";
            string expected = "";

            // Act
            var actual = StringHandler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpacesTestNullSource()
        {
            // Arrange
            string source = null;
            string expected = "";

            // Act
            var actual = StringHandler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
