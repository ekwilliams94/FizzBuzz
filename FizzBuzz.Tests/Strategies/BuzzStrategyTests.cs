using FizzBuzz.Strategies;

namespace FizzBuzz.Tests.Strategies
{
    public class BuzzStrategyTests
    {
        private readonly FizzStrategy sut = new();

        [Fact]
        public void ShouldReturnBuzz()
        {
            var result = sut.Execute();
            Assert.Equal("Buzz", result);
        }
    }
}