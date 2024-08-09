using FizzBuzz.Strategies;

namespace FizzBuzz.Tests.Strategies
{
    public class FizzStrategyTests
    {
        private readonly FizzStrategy sut = new();

        [Fact]
        public void ShouldReturnFizz()
        {
            var result = sut.Execute();
            Assert.Equal("Fizz", result);
        }
    }
}