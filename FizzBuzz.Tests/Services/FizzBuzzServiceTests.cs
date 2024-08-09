using FizzBuzz.Strategies;

namespace FizzBuzz.Tests.Services
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService sut = new();

        [Fact]
        public void ShouldReturnNumberWhenNotDivisbleBy3Or5() { 
            var result = sut.GetFizzBuzzOutput(1);
            Assert.Equal("1", result);        
        }

        [Fact]
        public void ShouldPrintFizzWhenNumberDivisibleBy3()
        {
            var result = sut.GetFizzBuzzOutput(9);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ShouldPrintBuzzWhenNumberDivisibleBy5()
        {
            var result = sut.GetFizzBuzzOutput(10);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(1, null)]
        [InlineData(3, typeof(FizzStrategy))]
        [InlineData(5, typeof(BuzzStrategy))]
        [InlineData(15, typeof(FizzBuzzStrategy))]

        public void GetStrategyType_ReturnsCorrectType(int input, Type expectedType)
        {
            var result = sut.GetStrategyType(input);
            Assert.Equal(expectedType, result);
        }
    }
}
