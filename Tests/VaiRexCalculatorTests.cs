using NUnit.Framework;
using System;
using TesteDTI.Services;

namespace TesteDTI.Tests
{
    
    [TestFixture]
    public class VaiRexCalculatorTests
    {
        [Test]
        public void CalculateCost_CalculateCostOnWeekday_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new VaiRex();
            var date = new DateTime(2023, 10, 20); // Uma sexta-feira
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.That(cost, Is.EqualTo(295.00m)); // O custo esperado para uma sexta-feira com 3 cães pequenos e 5 cães grandes
        }

        [Test]
        public void CalculateCost_CalculateCostOnWeekend_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new VaiRex();
            var date = new DateTime(2023, 10, 22); // Um domingo
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.That(cost, Is.EqualTo(335.00m)); // O custo esperado para um domingo com 3 cães pequenos e 5 cães grandes
        }
    }
}