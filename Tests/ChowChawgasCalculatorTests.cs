using NUnit.Framework;
using System;
using TesteDTI.Services;

namespace TesteDTI.Tests
{
    [TestFixture]
    public class ChowChawgasCalculatorTests
    {
        [Test]
        public void CalculateCost_ShouldReturnCorrectCost()
        {
            // Arrange
            var date = new DateTime(2023, 10, 20); // Uma sexta-feira
            var calculator = new ChowChawgas();
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.That(cost, Is.EqualTo(315.00m)); // O custo esperado para 3 cães pequenos e 5 cães grandes em qualquer dia da semana
        }
    }
}
