using NUnit.Framework;
using Patterns.Bridge;
using System;
using FluentAssertions;

namespace Patterns.Tests.Bridge
{
    [TestFixture]
    
    public class SaleTests
    {
        [Test]
        public void NormalPercentageDiscount_WhenInitialAmountIs_100_And_20PercentDiscountProvided_ThenReturns80()
        {
            // Arrange
            NormalSale normalSale = new NormalSale();
            PercentPriceStrategy percentPriceStrategy = new PercentPriceStrategy(20);
            decimal price = 100;

            // Act
            normalSale.SetStrategy(percentPriceStrategy);
            var result = normalSale.GetTotal(100);

            // Assert
            result.Should().Be(80);
        }

        [Test]
        public void WeekendPercentageDiscount_WhenInitialAmountIs_100_And_20PercentDiscountProvided_ThenReturns64()
        {
            // Arrange
            WeekendSale weekendSale = new WeekendSale();
            PercentPriceStrategy percentPriceStrategy = new PercentPriceStrategy(20);
            decimal price = 100;

            // Act
            weekendSale.SetStrategy(percentPriceStrategy);
            var result = weekendSale.GetTotal(price);

            // Assert
            result.Should().Be(64);
        }

        [Test]
        public void NormalAbsoluteDiscount_WhenInitialAmountIs_100_And_30DiscountProvided_ThenReturns70()
        {
            // Arrange
            NormalSale normalSale = new NormalSale();
            AbsolutePriceStrategy absolutePriceStrategy = new AbsolutePriceStrategy(30);
            decimal price = 100;

            // Act
            normalSale.SetStrategy(absolutePriceStrategy);
            var result = normalSale.GetTotal(price);

            // Assert
            result.Should().Be(70);
        }

        [Test]
        public void WeekendAbsoluteDiscount_WhenInitialAmountIs_100_And_30DiscountProvided_ThenReturns40()
        {
            // Arrange
            WeekendSale weekendSale = new WeekendSale();
            AbsolutePriceStrategy absolutePriceStrategy = new AbsolutePriceStrategy(30);
            decimal price = 100;

            // Act
            weekendSale.SetStrategy(absolutePriceStrategy);
            var result = weekendSale.GetTotal(price);

            // Assert
            result.Should().Be(40);
        }
    }
}
