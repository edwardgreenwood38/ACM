using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act
            var actual = orderRepository.Retrieve(10);

            // assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(1)
            {
                CustomerId = 1,
                OrderDate = DateTime.Now,
                OrderItems = new List<OrderItem>()
            {
                new OrderItem()
                {
                    Quantity = 1,
                    ProductId = 1,
                    PurchasePrice = 18
                },
                new OrderItem()
                {
                    Quantity = 1,
                    ProductId = 2,
                    PurchasePrice = 13
                }

            },
                HasChanges = true
            };

            // Act
            var actual = orderRepository.Save(updateOrder);

            // Assert
            Assert.AreEqual(true, actual);
        }


        [TestMethod]
        public void SaveTestMissingOrderDate()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(1)
            {
                CustomerId = 1,
                //OrderDate = DateTime.Now,
                OrderItems = new List<OrderItem>()
            {
                new OrderItem()
                {
                    Quantity = 1,
                    ProductId = 1,
                    PurchasePrice = 18
                },
                new OrderItem()
                {
                    Quantity = 1,
                    ProductId = 2,
                    PurchasePrice = 13
                }

            },
                HasChanges = true
            };

            // Act
            var actual = orderRepository.Save(updateOrder);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }

}
