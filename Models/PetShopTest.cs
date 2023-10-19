using NUnit.Framework;
using System;

namespace TesteDTI
{
    [TestFixture]
    public class MeuCaninoFelizCalculatorTests
    {
        [Test]
        public void CalculateCost_CalculateCostOnWeekday_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new MeuCaninoFelizCalculator();
            var date = new DateTime(2023, 10, 20); // Uma sexta-feira
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.AreEqual(260m, cost); // O custo esperado para uma sexta-feira com 3 cães pequenos e 5 cães grandes
        }

        [Test]
        public void CalculateCost_CalculateCostOnWeekend_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new MeuCaninoFelizCalculator();
            var date = new DateTime(2023, 10, 22); // Um domingo
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.AreEqual(312m, cost); // O custo esperado para um domingo com 3 cães pequenos e 5 cães grandes
        }
    }

    [TestFixture]
    public class VaiRexCalculatorTests
    {
        [Test]
        public void CalculateCost_CalculateCostOnWeekday_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new VaiRexCalculator();
            var date = new DateTime(2023, 10, 20); // Uma sexta-feira
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.AreEqual(295.00m, cost); // O custo esperado para uma sexta-feira com 3 cães pequenos e 5 cães grandes
        }

        [Test]
        public void CalculateCost_CalculateCostOnWeekend_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new VaiRexCalculator();
            var date = new DateTime(2023, 10, 22); // Um domingo
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(date, numSmallDogs, numLargeDogs);

            // Assert
            Assert.AreEqual(335.00m, cost); // O custo esperado para um domingo com 3 cães pequenos e 5 cães grandes
        }
    }

    [TestFixture]
    public class ChowChawgasCalculatorTests
    {
        [Test]
        public void CalculateCost_ShouldReturnCorrectCost()
        {
            // Arrange
            var calculator = new ChowChawgasCalculator();
            int numSmallDogs = 3;
            int numLargeDogs = 5;

            // Act
            decimal cost = calculator.CalculateCost(numSmallDogs, numLargeDogs);

            // Assert
            Assert.AreEqual(315.00m, cost); // O custo esperado para 3 cães pequenos e 5 cães grandes em qualquer dia da semana
        }
    }
}
