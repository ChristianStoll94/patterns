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
            PercentPriceStrategy percentpricestrategy = new PercentPriceStrategy(20);
            decimal orginalPrice = 100;

            // Act
            normalSale.setStrategy(percentpricestrategy);
            var result = normalSale.getTotal(100);

            // Assert
            result.Should().Be(80);
        }

        [Test]
        public void WeekendPercentageDiscount_WhenInitialAmountIs_100_And_20PercentDiscountProvided_ThenReturns64()
        {
            // Arrange
            WeekendSale weekendSale = new WeekendSale();
            PercentPriceStrategy percentpricestrategy = new PercentPriceStrategy(20);
            decimal orginalPrice = 100;

            // Act
            weekendSale.setStrategy(percentpricestrategy);
            var result = weekendSale.getTotal(orginalPrice);

            // Assert
            result.Should().Be(64);
        }

        [Test]
        public void NormalAbsoluteDiscount_WhenInitialAmountIs_100_And_30DiscountProvided_ThenReturns70()
        {
            // Arrange
            NormalSale normalSale = new NormalSale();
            AbsolutPriceStrategy absolutpricestrategy = new AbsolutPriceStrategy(30);
            decimal orginalPrice = 100;

            // Act
            normalSale.setStrategy(absolutpricestrategy);
            var result = normalSale.getTotal(orginalPrice);

            // Assert
            result.Should().Be(70);
        }

        [Test]
        public void WeekendAbsoluteDiscount_WhenInitialAmountIs_100_And_30DiscountProvided_ThenReturns40()
        {
            // Arrange
            WeekendSale weekendSale = new WeekendSale();
            AbsolutPriceStrategy absolutpricestrategy = new AbsolutPriceStrategy(30);
            decimal orginalPrice = 100;

            // Act
            weekendSale.setStrategy(absolutpricestrategy);
            var result = weekendSale.getTotal(orginalPrice);

            // Assert
            result.Should().Be(40);
        }
    }
}
