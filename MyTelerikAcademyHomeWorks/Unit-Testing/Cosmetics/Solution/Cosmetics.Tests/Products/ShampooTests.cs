﻿namespace Cosmetics.Tests.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Products;

    using NUnit.Framework;

    [TestFixture]
    public class ShampooTests
    {
        [Test]
        public void Print_WhenInvoked_ShouldReturnShampooDetailsWithValidStringFormat()
        {
            // Arrange
            var shampoo = new Shampoo("example", "Pesho", 10M, GenderType.Men, 100, UsageType.EveryDay);

            var expectedResult = new StringBuilder();
            expectedResult.AppendLine("- Pesho - example:");
            expectedResult.AppendLine("  * Price: $1000");
            expectedResult.AppendLine("  * For gender: Men");
            expectedResult.AppendLine("  * Quantity: 100 ml");
            expectedResult.Append("  * Usage: EveryDay");

            // Act
            var executionResult = shampoo.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), executionResult);
        }
    }
}