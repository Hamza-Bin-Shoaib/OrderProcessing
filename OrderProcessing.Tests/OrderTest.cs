using OrderProccessing.Models;
using Xunit;

namespace OrderProcessingApp.Tests.Models
{
    public class OrderTests
    {
        [Theory]
        [InlineData(100, "Loyal", 10)]
        [InlineData(99, "Loyal", 0)]
        [InlineData(150, "New", 0)]
        [InlineData(200, "Loyal", 20)]
        public void CalculateDiscount_ShouldApplyCorrectDiscount(decimal amount, string customerType, decimal expectedDiscount)
        {
            // Arrange
            var order = new Order { Amount = amount, CustomerType = customerType };

            // Act
            order.CalculateDiscount();

            // Assert
            Assert.Equal(expectedDiscount, order.Discount);
        }
    }
}
